using PortalRH.Domain.Entities;

namespace PortalRH.Domain.Interfaces;
public interface IUsuarioRepository
{
	List<Usuario> Lista();
	List<Pais> TesteConnection();
}