using Microsoft.AspNetCore.Mvc;
using PortalRH.Application.Interfaces;
using PortalRH.Application.ViewModels;
using PortalRH.Application.Models;

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
	public ActionResult<UsuarioViewModel> Get(int id)
	{
		return Ok(new UsuarioViewModel());
	}

	[HttpPost]
	public bool Post([FromBody] UsuarioModel usuario)
	{
		return true;
	}

	[HttpPut("{id}")]
	public bool Put(int id, [FromBody] UsuarioModel value)
	{
		return true;
	}

	[HttpDelete("{id}")]
	public bool Delete(int id)
	{
		return true;
	}

}