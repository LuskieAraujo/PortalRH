using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace PortalRH.Infra.Repositories;
public class Connection
{
	private static SqlConnection GetConnection()
	{
		return new SqlConnection("Server=localhost; Database=PortalRH; User Id=LuskieAraujo; Password=41503987809jl;");
	}

	public DataTable GetRegisters(string selectCommand)
	{
		var dt = new DataTable();

		try
		{
			using (SqlConnection conn = GetConnection())
			{
				conn.Open();

				foreach(DataRow dr in conn.Query(selectCommand))
					dt.Rows.Add(dr);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			dt = null;
		}

		return dt;
	}

	public bool UpdateRegister(string updateCommand)
	{
		try
		{
			using(SqlConnection conn = GetConnection())
			{
				conn.Open();
				conn.Execute(updateCommand);
			}

			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}

	public int Test()
	{
		int result = 0;
		using (SqlConnection conn = GetConnection())
		{
			conn.Open();
			result = conn.Query<int>("select top 1 from PortalRH.Login.Login").First();
		}

		return result;
	}
}