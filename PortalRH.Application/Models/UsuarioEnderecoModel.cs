namespace PortalRH.Application.Models;
public class UsuarioEnderecoModel
{
	public Guid Id { get; set; }
	public Guid IdUsuario { get; set; }
	public Guid IdEndereco { get; set; }
	public int Numero { get; set; }
	public string Complemento { get; set; }
	public bool Preferencial { get; set; }
}