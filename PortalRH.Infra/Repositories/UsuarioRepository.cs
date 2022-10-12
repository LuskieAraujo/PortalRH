using PortalRH.Domain.Entities;
using PortalRH.Domain.Interfaces;
using System.Data;

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
			return new List<Usuario>();
		}
	}

	public List<Pais> TesteConnection()
	{
		var conn = new Connection();
		List<Pais> lista = new List<Pais>();
		foreach (DataRow line in conn.Test().Rows)
		{
			lista.Add(new Pais
			{
				Id = (int)line["Id"],
				Nome = line["Nome"].ToString(),
				Nacionalidade = line["Nacionalidade"].ToString()
			});
		}

		return lista;
	}
}