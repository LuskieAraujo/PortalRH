using PortalRH.Domain.Entities;
using PortalRH.Domain.Interfaces;

namespace PortalRH.Infra.Repositories;
public class UsuarioRepository : IUsuarioRepository
{
	public List<Usuario> Lista()
	{
		try
		{
			return new List<Usuario>();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return new List<Usuario>
			{
				new Usuario
				{
					Id = 1,
					Name = "Lucas",
					Email = "lucas.araujo@be3.co"
				}
			};
		}
	}

	public int TesteConnection()
	{
		var conn = new Connection();
		return conn.Test();
	}
}