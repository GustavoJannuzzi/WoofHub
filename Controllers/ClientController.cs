using Microsoft.AspNetCore.Mvc;
using WoofHub_App.Models;
using WoofHub_App.Data;
using Microsoft.EntityFrameworkCore;

namespace WoofHub_App.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
	private WoofHubContext _context;
	private readonly ILogger<ClientController> _logger;
	public ClientController(ILogger<ClientController> logger)
	{
		_logger = logger;
	}

	public ClientController(WoofHubContext context)
	{
		_context = context;
	}

	[HttpGet()]
	[Route("get")]
	public async Task<ActionResult<IEnumerable<ClientModel>>> Get()
	{
		if (_context.ClientModel is null)
			return NotFound();
		return await _context.ClientModel.ToListAsync();
	}

	[HttpGet()]
	[Route("search/{ClientCpf}")]
	public async Task<ActionResult<ClientModel>> Search([FromRoute] string ClientCpf)
	{
		if (_context.ClientModel is null)
			return NotFound();
		var client = await _context.ClientModel.FindAsync(ClientCpf);
		if (client is null)
			return NotFound();
		return client;
	}

	[HttpPost]
	[Route("insert")]
	public async Task<ActionResult<ClientModel>> Insert(ClientModel client)
	{
		if (!ClientModel.IsCpf(client.Cpf))
			return BadRequest("CPF inv�lido!");

		_context.ClientModel.Add(client);
		await _context.SaveChangesAsync();

		return Created("", client);
	}
}
