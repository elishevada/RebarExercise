using Microsoft.AspNetCore.Mvc;
using RebarExercise.Data;
using RebarExercise.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly MongoDBContext _context;

    public OrdersController(MongoDBContext context)
    {
        _context = context;
    }
    //  public ActionResult index()
    //  {

    //return  
    //  }

    [HttpGet]
    public async Task<List<Order>> Get()//could be instead of menu class//list 
    {
        return await _context.Orders.Find(_ => true).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Order>> Get(Guid id)////////guid 
    {
        var order = await _context.Orders.Find(o => o.OrderId == id).FirstOrDefaultAsync();

        if (order == null)
        {
            return NotFound();
        }

        return order;
    }

    [HttpPost]
    public async Task<ActionResult<Order>> Create(Order order)
    {
        foreach(var shake in order.Shakes)
        {
            order.TotalShakes += shake.Price;
        }
        
        if (order.Shakes.Count() > 10&& order.CustomersName!=null)
        {
            return NotFound();//turn that is too many for a order 
        }
        await _context.Orders.InsertOneAsync(order);
        return CreatedAtRoute(new { id = order.OrderId }, order);
    }
    //public ActionResult Shake()
    //{
    //       return View();
    //   }


}