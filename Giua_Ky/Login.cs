using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
namespace Giua_Ky
{
	public partial class Login : Form
	{

		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = Connect_Database.GetConnection())
			{

				string username = txtUserName.Text;
				string pass = txtPass.Text;

				// tim username, Password trong bang Account trung voi usename nhap trong form 
				string query = "SELECT COUNT(*) FROM Customer WHERE Username = @UserName";
				int count = 0;

				// neu tim thay thi tang gia tri bien count
				using (SqlCommand command = new SqlCommand(query, connection))
				{

					command.Parameters.AddWithValue("@UserName", username);
					count = (int)command.ExecuteScalar();

				}

				// user khong ton tai => bao loi  
				if (count == 0)
				{
					MessageBox.Show("User not found. Please sign up.");
				}
				else
				{
					// neu dang nhap admin thi chuyen den form quan ly thong tin 
					if (username == "admin" && pass == "123")
					{
						this.Hide();
						Customer_Management cm = new Customer_Management();
						cm.Show();
					}
					else
					{
						// con lai chuyen den form thue xe
						this.Hide();
						SelectCar selectCarForm = new SelectCar();
						selectCarForm.Show();
					}

				}
			}
		}

		// che password khi nhap
		private void txtPass_TextChanged(object sender, EventArgs e)
		{
			if (txtPass.PasswordChar == '\0')
			{
				txtPass.PasswordChar = '*';
			}
		}

		// dan den trang dang ky tai khoan
		private void btnSignUp_Click(object sender, EventArgs e)
		{
			SignUp sg = new SignUp();
			sg.ShowDialog();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
