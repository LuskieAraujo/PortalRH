using PortalRH.Application.Interfaces;
using PortalRH.Application.ViewModels;
using PortalRH.Domain.Interfaces;

namespace PortalRH.Application.Services;
public class UsuarioService : IUsuarioService
{
	private readonly IUsuarioRepository _usuarioRepository;

	public UsuarioService(IUsuarioRepository usuarioRepository)
	{
		_usuarioRepository = usuarioRepository;
	}

	public List<UsuarioViewModel> ListaUsuarios()
	{
		var usuarios = new List<UsuarioViewModel>();

		foreach (var u in _usuarioRepository.Lista())
			usuarios.Add(new UsuarioViewModel()
			{
				Name = u.Name,
				Email = u.Email,
				Id = u.Id
			});

		return usuarios;
	}

	public List<PaisViewModel> TesteConexao()
	{
		var retorno = new List<PaisViewModel>();
		foreach(var linha in _usuarioRepository.TesteConnection())
		{
			retorno.Add(new PaisViewModel()
			{
				Id = linha.Id,
				Nome = linha.Nome,
				Nacionalidade = linha.Nacionalidade
			});
		}

		return retorno;
	}
}