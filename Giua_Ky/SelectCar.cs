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
	public partial class SelectCar : Form
	{
		public SelectCar()
		{
			InitializeComponent();
			LoadData();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		// Mini 
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Mini mini = new Mini();
			mini.ShowDialog();
		}

		// hien thi danh danh sach xe
		private void LoadData()
		{

			using (SqlConnection connection = Connect_Database.GetConnection())
			{
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

					//// Rented_Status co kieu du lieu la bit trong database (de bieu hien 2 trang thai) 
					//// xu ly de hien len DataGridView 2 thang thai  "chua cho thue" va " da cho thue "
					//string rentedStatus = rented ? "Rented" : "Available";

					// chen dulieu vao gridCustomer
					gridCar.Rows.Add(carID, carTpye, manufacturer, carName, rented, seats, price);
				}

				reader.Close();
			}

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
			Login login = new Login();
			login.Show();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			
		}
	}
}
