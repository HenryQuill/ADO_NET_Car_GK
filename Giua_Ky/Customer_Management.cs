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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Giua_Ky
{
	public partial class Customer_Management : Form
	{
		public Customer_Management()
		{
			InitializeComponent();
			LoadData();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
			Login login = new Login();
			login.Show();
		}

		private void gridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		// hien thi danh danh sach khach hang
		private void LoadData()
		{
			using (SqlConnection connection = Connect_Database.GetConnection())
			{
				string query = "SELECT UserName, Password, Name, Phone, Address FROM Customer";

				SqlCommand command = new SqlCommand(query, connection);
				SqlDataReader reader = command.ExecuteReader();

				// doc du lieu trong database
				while (reader.Read())
				{
					string userName = reader.GetString(0);
					string password = reader.GetString(1);
					string name = reader.GetString(2);
					string phone = reader.GetString(3);
					string address = reader.GetString(4);

					// chen dulieu vao gridCustomer
					gridCustomer.Rows.Add(userName, password, name, phone, address);
				}

				reader.Close();
			}
		}

		// them Khach hang
		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = Connect_Database.GetConnection())
			{
				SaveNewCustomerToDatabase(gridCustomer.CurrentRow);

			}

		}

		// luu khach hang vua tao vao database
		private void SaveNewCustomerToDatabase(DataGridViewRow row)
		{
			string connectionString = "Data Source=HQ\\SQLEXPRESS;Initial Catalog=Car_Renting;Integrated Security=True;TrustServerCertificate=true";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				// tao 1 doi tuong SqlCommand de thuc thi cau lenh INSERT
				using (SqlCommand command = new SqlCommand("INSERT INTO Customer (UserName, Password, Name, Phone, Address) VALUES (@UserName, @Password, @Name, @Phone, @Address)", connection))
				{
					// tiep tuc them cac gia tri vua nhap tren DataGridView
					command.Parameters.AddWithValue("@UserName", row.Cells[0].Value);
					command.Parameters.AddWithValue("@Password", row.Cells[1].Value);
					command.Parameters.AddWithValue("@Name", row.Cells[2].Value);
					command.Parameters.AddWithValue("@Phone", row.Cells[3].Value);
					command.Parameters.AddWithValue("@Address", row.Cells[4].Value);

					// thuc thi lenh INSERT
					command.ExecuteNonQuery();
				}
				connection.Close();
			}
		}

		// xoa khach hang khoi database
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (gridCustomer.SelectedRows.Count > 0)
			{
				// xu ly khi click vao 1 dong du lieu
				DataGridViewRow selectedRow = gridCustomer.SelectedRows[0];

				// lay username 
				string username = selectedRow.Cells["UserName"].Value.ToString();

				// xoa khach hang khoi database 
				string connectionString = "Data Source=HQ\\SQLEXPRESS;Initial Catalog=Car_Renting;Integrated Security=True;TrustServerCertificate=true";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					string query = "DELETE FROM Customer WHERE UserName = @Username";
					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@Username", username);
					command.ExecuteNonQuery();

					connection.Close();
				}

				// xoa khach hang khoi grid Customer
				gridCustomer.Rows.Remove(selectedRow);
			}
		}

		// luu vi tri cua hang du lieu vua chon
		private int selectedRowIndex;
		private void gridCustomer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			selectedRowIndex = e.RowIndex;
		}

		// chinh sua thong tin khach hang
		private void btnEdit_Click(object sender, EventArgs e)
		{
			// neu hang du lieu da chon nam trong pham vi thi thuc hien update  
			if (selectedRowIndex >= 0 && selectedRowIndex < gridCustomer.Rows.Count)
			{
				DataGridViewRow selectedRow = gridCustomer.Rows[selectedRowIndex];
				string userName = selectedRow.Cells["UserName"].Value.ToString();

				// update du lieu trong database 
				UpdateCustomerInDatabase(userName, selectedRow);
			}
		}
		// update du lieu trong database 
		private void UpdateCustomerInDatabase(string userName, DataGridViewRow selectedRow)
		{
			string connectionString = "Data Source=HQ\\SQLEXPRESS;Initial Catalog=Car_Renting;Integrated Security=True;TrustServerCertificate=true";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "UPDATE Customer SET Password = @Password, Name = @Name, Phone = @Phone, Address = @Address WHERE UserName = @UserName";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@UserName", userName);
					command.Parameters.AddWithValue("@Password", selectedRow.Cells["Password"].Value.ToString());
					command.Parameters.AddWithValue("@Name", selectedRow.Cells["CustomerName"].Value.ToString());
					command.Parameters.AddWithValue("@Phone", selectedRow.Cells["Phone"].Value.ToString());
					command.Parameters.AddWithValue("@Address", selectedRow.Cells["Address"].Value.ToString());

					command.ExecuteNonQuery();
				}
				connection.Close();
			}
		}

		private void btnCar_Click(object sender, EventArgs e)
		{
			this.Close();
			Car_Management cm = new Car_Management();
			cm.Show();
		}


	}
}
