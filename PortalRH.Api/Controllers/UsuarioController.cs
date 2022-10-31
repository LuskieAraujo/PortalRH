using Microsoft.AspNetCore.Mvc;
using PortalRH.Application.Interfaces;
using PortalRH.Application.ViewModels;

namespace PortalRH.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
	private readonly IUsuarioService _usuarioService;
	public UsuarioController(IUsuarioService usuarioService)
	{
		_usuarioService = usuarioService;
	}
	[HttpGet]
	public ActionResult<List<UsuarioViewModel>> Get()
	{
		return Ok(_usuarioService.ListaUsuarios());
	}

	[HttpGet("{id}")]
	public string Get(int id)
	{
		return "value";
	}

	[HttpPost]
	public void Post([FromBody] string value)
	{

	}

	[HttpPut("{id}")]
	public void Put(int id, [FromBody] string value)
	{

	}

	[HttpDelete("{id}")]
	public void Delete(int id)
	{

	}

	[HttpGet("test")]
	public List<PaisViewModel> TestConnection()
	{
		
	}
}