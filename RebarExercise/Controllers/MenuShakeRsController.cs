using Microsoft.AspNetCore.Mvc;
using RebarExercise.Data;
using RebarExercise.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;


[ApiController]
[Route("api/[controller]")]
public class MenuShakeRsController : ControllerBase
{
	private readonly MongoDBContext _context;

	public MenuShakeRsController(MongoDBContext context)
	{
		_context = context;
	}

	[HttpGet]
	public async Task<IEnumerable<MenuShake>> Get()
	{
		return await _context.MenuShakes.Find(_ => true).ToListAsync();
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<MenuShake>> Get(Guid id)////////guid 
	{
		var product = await _context.MenuShakes.Find(p => p.ShakeId == id).FirstOrDefaultAsync();

		if (product == null)
		{
			return NotFound();
		}

		return product;
	}

	[HttpPost]
	public async Task<ActionResult<MenuShake>> Create(MenuShake menuShakeRs)
	{
		await _context.MenuShakes.InsertOneAsync(menuShakeRs);
		return CreatedAtRoute(new { id = menuShakeRs.ShakeId }, menuShakeRs);
	}

	
}