using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Giua_Ky
{
	public partial class Car_Management : Form
	{
		public Car_Management()
		{
			InitializeComponent();
			LoadData();
		}

		// hien thi danh danh sach xe
		private void LoadData()
		{
			string connectionString = "Data Source=HQ\\SQLEXPRESS;Initial Catalog=Car_Renting;Integrated Security=True;TrustServerCertificate=true";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "SELECT Car_ID, Car_Type, Manufacturer, Car_Name, Rented_Status, Seats, Price FROM Car";

				SqlCommand command = new SqlCommand(query, connection);
				SqlDataReader reader = command.ExecuteReader();

				// doc du lieu trong database
				while (reader.Read())
				{
					int carID = reader.GetInt32(0);
					string carTpye = reader.GetString(1);
					string manufacturer = reader.GetString(2);
					string carName = reader.GetString(3);
					bool rented = reader.GetBoolean(4);
					int seats = reader.GetInt32(5);
					int price = reader.GetInt32(6);

					// chen dulieu vao gridCustomer
					gridCar.Rows.Add(carID, carTpye, manufacturer, carName, rented, seats, price);
				}

				reader.Close();
				connection.Close();
			}

		}
		private void btnImport_Click(object sender, EventArgs e)
		{

		}

		// them xe vao database
		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = Connect_Database.GetConnection())
			{
				SaveNewCarToDatabase(gridCar.CurrentRow);

			}
		}

		// luu xe vua tao vao database
		private void SaveNewCarToDatabase(DataGridViewRow row)
		{
			string connectionString = "Data Source=HQ\\SQLEXPRESS;Initial Catalog=Car_Renting;Integrated Security=True;TrustServerCertificate=true";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				// tao 1 doi tuong SqlCommand de thuc thi cau lenh INSERT
				using (SqlCommand command = new SqlCommand("INSERT INTO Car (Car_ID, Car_Type, Manufacturer, Car_Name, Rented_Status, Seats, Price) VALUES (@Car_ID, @Car_Type, @Manufacturer, @Car_Name, @Rented_Status, @Seats, @Price)", connection))
				{
					// tiep tuc them cac gia tri vua nhap tren DataGridView
					command.Parameters.AddWithValue("@Car_ID", row.Cells[0].Value);
					command.Parameters.AddWithValue("@Car_Type", row.Cells[1].Value);
					command.Parameters.AddWithValue("@Manufacturer", row.Cells[2].Value);
					command.Parameters.AddWithValue("@Car_Name", row.Cells[3].Value);
					command.Parameters.AddWithValue("@Rented_Status", Convert.ToBoolean(row.Cells[4].Value)); // chuyen ve boolean
					command.Parameters.AddWithValue("@Seats", row.Cells[5].Value);
					command.Parameters.AddWithValue("@Price", row.Cells[6].Value);
					// thuc thi lenh INSERT
					command.ExecuteNonQuery();
				}
				connection.Close();
			}
		}

		// xoa xe khoi database va gridCar
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (gridCar.SelectedRows.Count > 0)
			{
				// xu ly khi click vao 1 dong du lieu
				DataGridViewRow selectedRow = gridCar.SelectedRows[0];

				// lay id cua xe 
				string carid = selectedRow.Cells["Car_ID"].Value.ToString();

				// xoa xe khoi database 
				string connectionString = "Data Source=HQ\\SQLEXPRESS;Initial Catalog=Car_Renting;Integrated Security=True;TrustServerCertificate=true";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					string query = "DELETE FROM Car WHERE Car_ID = @Car_ID";
					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@Car_ID", carid);
					command.ExecuteNonQuery();

					connection.Close();
				}

				// xoa xe khoi gridCar
				gridCar.Rows.Remove(selectedRow);
			}
		}

		// luu vi tri cua hang du lieu vua chon
		private int selectedRowIndex;
		private void gridCar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			selectedRowIndex = e.RowIndex;
		}

		// chinh sua thong tin xe
		private void btnEdit_Click(object sender, EventArgs e)
		{
			// neu hang du lieu da chon nam trong pham vi thi thuc hien update  
			if (selectedRowIndex >= 0 && selectedRowIndex < gridCar.Rows.Count)
			{
				DataGridViewRow selectedRow = gridCar.Rows[selectedRowIndex];
				string userName = selectedRow.Cells["Car_ID"].Value.ToString();

				// update du lieu trong database 
				UpdateCarInDatabase(userName, selectedRow);
			}
		}
		// update du lieu trong database 
		private void UpdateCarInDatabase(string carid, DataGridViewRow selectedRow)
		{
			string connectionString = "Data Source=HQ\\SQLEXPRESS;Initial Catalog=Car_Renting;Integrated Security=True;TrustServerCertificate=true";
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "UPDATE Car SET Car_Type = @Car_Type, Manufacturer = @Manufacturer, Car_Name = @Car_Name, Rented_Status = @Rented_Status, Seats=@Seats, Price=@Price WHERE Car_ID = @Car_ID";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Car_ID", carid);
					command.Parameters.AddWithValue("@Car_Type", selectedRow.Cells["Car_Type"].Value.ToString());
					command.Parameters.AddWithValue("@Car_Name", selectedRow.Cells["Car_Name"].Value.ToString());
					command.Parameters.AddWithValue("@Manufacturer", selectedRow.Cells["Manufacturer"].Value.ToString());
					// chuyen ve dang du lieu bit cua database 
					bool rentedStatus = Convert.ToBoolean(selectedRow.Cells["Rented_Status"].Value);
					command.Parameters.AddWithValue("@Rented_Status", rentedStatus);
					command.Parameters.AddWithValue("@Seats", selectedRow.Cells["Seats"].Value.ToString());
					command.Parameters.AddWithValue("@Price", selectedRow.Cells["Price"].Value.ToString());

					command.ExecuteNonQuery();
				}
				connection.Close();
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
			Login lg = new Login();
			lg.Show();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

		}

		private void gridCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
