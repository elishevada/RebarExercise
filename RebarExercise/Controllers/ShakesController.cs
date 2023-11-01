using Microsoft.AspNetCore.Mvc;
using RebarExercise.Data;
using RebarExercise.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

[ApiController]
[Route("api/[controller]")]
public class ShakesController : ControllerBase
{
	private readonly MongoDBContext _context;

	public ShakesController(MongoDBContext context)
	{
		_context = context;
	}
	//public ActionResult index()
	//{

	//	return View();

	//}

	[HttpGet]
	public async Task<List<Shake>> Get()//could be instead of menu class//list 
	{
		return await _context.Shakes.Find(_ => true).ToListAsync();
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<Shake>> Get(Guid id)////////guid 
	{
		var product = await _context.Shakes.Find(s => s.MenuShakeId == id).FirstOrDefaultAsync();

		if (product == null)
		{
			return NotFound();
		}

		return product;
	}

	[HttpPost]
	public async Task<ActionResult<Shake>> Create(Shake shake)
	{
		await _context.Shakes.InsertOneAsync(shake);
		return CreatedAtRoute(new { id = shake.MenuShakeId }, shake);
	} 
	//public ActionResult Shake()
	//{
 //       return View();
 //   }


}