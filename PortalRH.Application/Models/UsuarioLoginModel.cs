namespace PortalRH.Application.Models;
public class UsuarioLoginModel
{
	public Guid Id { get; set; }
	public bool Ativo { get; set; }
	public string NomeUsuario { get; set; }
	public string Senha { get; set; }
	public bool PrimeiroAcesso { get; set; }
	public string RecuperacaoPergunta { get; set; }
	public string RecuperacaoResposta { get; set; }
}