using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Day_8
{
	class DeleteDemo
	{
		static void Main(string[] args)
		{
			SqlConnection connection = new SqlConnection("Data Source=EC2AMAZ-2675HTI;" +
			  "Initial Catalog=TrainingDB;Integrated Security=true");
			connection.Open();
			SqlCommand command = new SqlCommand("usp_DeleteEmpRecord", connection);

			command.CommandType = System.Data.CommandType.StoredProcedure;

			command.Parameters.AddWithValue("@empId", 3);
			//command.Parameters.AddWithValue("@newSalary", 80000);

			int rowsAffected = command.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				Console.WriteLine("Record Deleted successlly");
			}
			else
			{
				Console.WriteLine("Error");
			}
		}
	}
}
