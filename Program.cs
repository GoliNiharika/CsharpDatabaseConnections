using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day_8
{
	class Program
	{
		static void Main(string[] args)
		{																																															//
			SqlConnection connection = new SqlConnection("Data Source=LAPTOP-SBNNK5K4;Initial Catalog=WeatherDB;Integrated Security=true");
			connection.Open();
			SqlCommand command = new SqlCommand("Select * from UserDetails", connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				Console.WriteLine( reader[0]+", "+reader["User_First_Name"]+", "+reader["User_Last_Name"]);
			}
			//2



			connection.Close();
		}
	}
}
