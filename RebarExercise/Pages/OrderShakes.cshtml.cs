using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using RebarExercise.Data;
using RebarExercise.Models;
using System;

namespace RebarExercise.Pages
{
    [BindProperties]
    public class OrderShakesModel : PageModel
    {
        public string OrderShakesId { get; set; }=string.Empty;
        public string ShakesIdsForSavingSizesOrder { get; set; }=string.Empty;
        public string Sizes { get; set; } = string.Empty;
        public Order Order = new Order();
        public List<Shake> AllMenuShakes { get; set; }
        public DateTime OrderStartTime { get; set; }
        public DateTime OrderEndTime { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal TotalShakes { get; set; } = 0;
        private readonly MongoDBContext _context;
        public OrderShakesModel(MongoDBContext context)
        {
            _context = context;
        }



        public void OnGet()
        {
            OrderStartTime = DateTime.Now;
            AllMenuShakes = _context.Shakes.Find(_ => true).ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Order = new Order();
            Order.Shakes = new List<OrderShake>();
            List<string> SizesList = Sizes.Split(',').ToList();
            List<string> MatchSizesIds = ShakesIdsForSavingSizesOrder.Split(',').ToList();           
            for (int i=0; i< MatchSizesIds.Count(); i++)
            {               
                OrderShake newOrderShake=new OrderShake();
                newOrderShake.Shake = new Shake();
                newOrderShake.Shake.Name = _context.Shakes.Find(o => o.MenuShakeId.ToString() == MatchSizesIds[i]).First().Name;
                newOrderShake.Shake.Description = _context.Shakes.Find(o => o.MenuShakeId.ToString() == MatchSizesIds[i]).First().Description;
                newOrderShake.Shake.PriceS = _context.Shakes.Find(o => o.MenuShakeId.ToString() == MatchSizesIds[i]).First().PriceS;
                newOrderShake.Shake.PriceM = _context.Shakes.Find(o => o.MenuShakeId.ToString() == MatchSizesIds[i]).First().PriceM;
                newOrderShake.Shake.PriceL = _context.Shakes.Find(o => o.MenuShakeId.ToString() == MatchSizesIds[i]).First().PriceL;              
                if (SizesList[i] == "S")
                {
                    newOrderShake.Price = newOrderShake.Shake.PriceS;
                    newOrderShake.ShakeSize = Size.Small;
                }
                if (SizesList[i] == "M")
                {
                    newOrderShake.Price = newOrderShake.Shake.PriceM;
                    newOrderShake.ShakeSize = Size.Medium;
                }
                if (SizesList[i] == "L")
                {
                    newOrderShake.Price = newOrderShake.Shake.PriceL;
                    newOrderShake.ShakeSize = Size.Large;
                }
                Order.Shakes.Add(newOrderShake);
                TotalShakes += newOrderShake.Price;
            }            
            Order.OrderEndDate = DateTime.Now;
            Order.CustomersName = CustomerName;
            Order.OrderDateCreation = OrderStartTime;
            await _context.Orders.InsertOneAsync(Order);
            return RedirectToPage("SuccesOrder");
        }
    }
}
