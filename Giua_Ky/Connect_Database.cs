using Microsoft.Data.SqlClient;

namespace Giua_Ky
{
	internal class Connect_Database
	{
		static SqlConnection connection;
		public static SqlConnection GetConnection()
		{
			if (connection == null)
			{
				SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
				builder["Data Source"] = "HQ\\SQLEXPRESS";
				builder["Integrated Security"] = true;
				builder["Initial Catalog"] = "Car_Renting";
				builder["TrustServerCertificate"] = true;
				builder.UserID = "";
				connection = new SqlConnection(builder.ConnectionString);
				connection.Open();
				return connection;
			}else
				return connection;
			
		}

	}
}
