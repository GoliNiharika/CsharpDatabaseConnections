using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Day_8
{
	class UpdateDemo
	{
		static void Main(string[] args)
		{
			SqlConnection connection = new SqlConnection("Data Source=LAPTOP-SBNNK5K4;" +
			  "Initial Catalog=WeatherDB;Integrated Security=true");
			connection.Open();
			SqlCommand command = new SqlCommand("usp_UpdateEmpSalary", connection);

			command.CommandType = System.Data.CommandType.StoredProcedure;

			
			command.Parameters.Add("@empId", SqlDbType.Int);
			command.Parameters["@empId"].Value = Convert.ToInt32(Console.ReadLine());

			//command.Parameters.AddWithValue("@empId", 1);
			command.Parameters.AddWithValue("@newSalary", 80000);

			int rowsAffected = command.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				Console.WriteLine("Record Updated successlly");
			}
			else
			{
				Console.WriteLine("Error");
			}
		}
	}
}
