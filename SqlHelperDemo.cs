using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace Day_8
{
	class SqlHelperDemo
	{
		static void Main(string[] args)
		{
			SqlDataReader reader = SqlHelper.ExecuteReader("Data Source=EC2AMAZ-2675HTI;Initial Catalog=TrainingDB;Integrated Security=true", System.Data.CommandType.Text,"select * from employees");
			while (reader.Read())
			{
				Console.WriteLine( reader[0]+", "+reader[1]+", "+reader[2]);
			}
		}
	}
}
