using MongoDB.Bson.Serialization.Attributes;

namespace RebarExercise.Models
{
	public record Discount(string Name, double Percent);
	public class Order
	{
		[BsonId]
		public Guid OrderId { get; }= Guid.NewGuid();
        public List<OrderShake>? Shakes { get; set; }
        [BsonElement("totalShakes")]
        public decimal TotalShakes { get; set; }
        [BsonElement("customersName")]
        public string CustomersName { get; set; }= string.Empty;
        [BsonElement("orderDateCreation")]
        public DateTime OrderDateCreation { get; set; }= DateTime.Now;
        public DateTime OrderEndDate { get; set; }
        public List<Discount> Discounts { get; set; }
		//public List<OrderShake> OrderShakes { get; set;}//i need a list of shakes or list of id of shakes 
		
		
	}
}
