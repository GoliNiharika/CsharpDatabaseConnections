using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Day_8
{
	class DisconnectedDemo
	{
		static void Main(string[] args)
		{
			SqlConnection connection = null;
			try
			{

				connection = new SqlConnection("Data Source=LAPTOP-SBNNK5K4;" +
				 "Initial Catalog=WeatherDB;Integrated Security=true");
				SqlCommand command = new SqlCommand("select * from UserDetails", connection);
				SqlCommand command2 = new SqlCommand("select * from WeatherDetails", connection);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				SqlDataAdapter adapter2 = new SqlDataAdapter(command2);

					DataSet ds = new DataSet();
				Console.WriteLine( connection.State);

				adapter.Fill(ds, "UserDetails");
				adapter2.Fill(ds, "WeatherDetails");
					Console.WriteLine(connection.State);

				DataTable dt = ds.Tables["UserDetails"];
				Console.WriteLine(connection.State);

				foreach (DataRow row in dt.Rows)
				{
					Console.WriteLine( row[0]+", "+row[1]+", "+ row[2] + ", " + row[3]);
				}

				DataTable dt2 = ds.Tables["WeatherDetails"];

				foreach (DataRow row in dt2.Rows)
				{
						Console.WriteLine(row[0] + ", " + row[1]);
				}

			}
			catch (SqlException ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				if (connection.State == ConnectionState.Open)
				{
					connection.Close();
				}
			}

			Console.ReadLine();
		}
		
	}
}
