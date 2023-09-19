using Microsoft.AspNetCore.Mvc;
using WoofHub.Models;
using WoofHub.Data;
using Microsoft.EntityFrameworkCore;

namespace WoofHub.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
	private WoofHubDbContext _context;
	private readonly ILogger<ClientController> _logger;
	public ClientController(ILogger<ClientController> logger)
	{
		_logger = logger;
	}

	public ClientController(WoofHubDbContext context)
	{
		_context = context;
	}

	[HttpGet()]
	[Route("get")]
	public async Task<ActionResult<IEnumerable<Client>>> Get()
	{
		if (_context.Client is null)
			return NotFound();
		return await _context.Client.ToListAsync();
	}

	[HttpGet()]
	[Route("search/{cpf}")]
	public async Task<ActionResult<Client>> Search([FromRoute] string cpf)
	{
		if (_context.Client is null)
			return NotFound();
		var client = await _context.Client.FindAsync(cpf);
		if (client is null)
			return NotFound();
		return client;
	}

	[HttpPost]
	[Route("insert")]
	public async Task<ActionResult<Client>> Insert(Client client)
	{
		if (!Client.IsCpf(client.Cpf))
			return BadRequest("CPF inv�lido!");

		_context.Client.Add(client);
		await _context.SaveChangesAsync();

		return Created("", client);
	}
}
