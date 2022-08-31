using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Day_8
{
	class InsertDemo
	{
		static void Main(string[] args)
		{
			SqlConnection connection = new SqlConnection("Data Source=EC2AMAZ-2675HTI;" +
			   "Initial Catalog=TrainingDB;Integrated Security=true");
			connection.Open();
			SqlCommand insertCommand = new SqlCommand("insert into Employees(EmplId,EmpName,Joining_Date,Salary,Designation,DeptId) values(@empId,@empName,@joining_Date,@salary,@desg,@depId)",connection);
			insertCommand.Parameters.Add("@empId", SqlDbType.Int);
			insertCommand.Parameters.Add("@empName", SqlDbType.VarChar, 20);
			insertCommand.Parameters.Add("@joining_Date", SqlDbType.Date);
			insertCommand.Parameters.Add("@salary", SqlDbType.Decimal);
			insertCommand.Parameters.Add("@desg", SqlDbType.Char);
			insertCommand.Parameters.Add("@depId", SqlDbType.Int);

			insertCommand.Parameters["@empId"].Value = Convert.ToInt32(Console.ReadLine());
			insertCommand.Parameters["@empName"].Value =Console.ReadLine();
			insertCommand.Parameters["@joining_Date"].Value =Console.ReadLine();
			insertCommand.Parameters["@salary"].Value = Convert.ToDecimal(Console.ReadLine());
			insertCommand.Parameters["@desg"].Value = Console.ReadLine();
			insertCommand.Parameters["@depId"].Value = Convert.ToInt32(Console.ReadLine());

			int rowsAffected = insertCommand.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				Console.WriteLine( "Record added successlly");
			}
			else
			{
				Console.WriteLine( "Error");
			}
		}

	}
}
