using MongoDB.Bson.Serialization.Attributes;

namespace RebarExercise.Models
{
	public record Discount(string Name, double Percent);
	public class Order
	{
		[BsonId]
		public Guid OrderId { get; set; }
		public OrderShake Shakes { get; set; }
		public decimal TotalShakes { get; set; }
		public string customersName { get; set; }
		public DateTime OrderDate { get; set; }
		public Discount Discount { get; set; }
		//public List<OrderShake> OrderShakes { get; set;}//i need a list of shakes or list of id of shakes 
		
		
	}
}
