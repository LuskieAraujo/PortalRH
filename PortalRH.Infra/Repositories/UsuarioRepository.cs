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
	public Usuario BuscaUsuario(int id)
	{
		try
		{
			Usuario usuario = new Usuario();



			return usuario;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return new Usuario();
		}
	}

}