using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giua_Ky
{
	public partial class SignUp : Form
	{
		public SignUp()
		{
			InitializeComponent();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			
		}

		// them thong tin khach hang ???
		private void btnSignUp_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = Connect_Database.GetConnection())
			{

				string username = txtUserName.Text;
				string password = txtPass.Text;
				string name = txtName.Text;
				string phone = txtPhone.Text;
				string address = txtAddress.Text;
				

				// tim username trong bang Account trung voi usename nhap trong form 
				// neu tim thay thi tang bien count len 1 
				string query = "SELECT COUNT(*) FROM Customer WHERE Username = @UserName";
				int count = 0;
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@UserName", username);
					count = (int)command.ExecuteScalar();
				}

				// count=1 => trung username => bao loi 
				if (count == 1){
					MessageBox.Show("User already existed. Please login or change your username.");
				}else{ 

					// dung 1 query de chen cac gia tri cua vao bang Account
					string query1 = "INSERT INTO Customer (UserName, Password, Name, Phone, Address) VALUES (@UserName, @Password, @Name, @Phone, @Address)";

					using (SqlCommand command = new SqlCommand(query1, connection))
					{
						// luu cac gia tri nhap tren form vao database 
						command.Parameters.AddWithValue("@UserName", username);
						command.Parameters.AddWithValue("@Password", password);
						command.Parameters.AddWithValue("@Name", name);
						command.Parameters.AddWithValue("@Phone", phone);
						command.Parameters.AddWithValue("@Address", address);
						command.ExecuteNonQuery();
					}

					MessageBox.Show("Account created successfully!");

					// clear cac textbox sau khi luu thanh cong
					txtUserName.Text = string.Empty;
					txtPass.Text = string.Empty;
					txtName.Text=string.Empty;
					txtPhone.Text = string.Empty;
					txtAddress.Text = string.Empty;
				}

			}
		}

		// quay lai form login
		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			
		}
	}
}
