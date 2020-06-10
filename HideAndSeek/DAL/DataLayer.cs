using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeek.DAL
{
	public class DataLayer
	{
		public SqlConnection SqlConnection()
		{
			string connectionString = "Data Source=localhost;Initial Catalog=/*DatabaseName*/;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			return connection;
		}
	}
}
