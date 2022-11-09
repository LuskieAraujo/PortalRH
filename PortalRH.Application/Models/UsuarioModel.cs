namespace PortalRH.Application.Models;
public class UsuarioModel
{
	public Guid Id { get; set; }
	public string NomeCompleto { get; set; }
	public DateTime DataNascimento { get; set; }
	public int Nacionalidade { get; set; }
	public UsuarioLoginModel LoginModel { get; set; }
	public UsuarioEnderecoModel EnderecoModel { get; set; }
}