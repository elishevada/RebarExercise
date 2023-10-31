using MongoDB.Bson.Serialization.Attributes;

namespace RebarExercise.Models
{
	//i can take off the shake class and do a record only if i have no methods in shake class
	//public record Shake(ShakeBase ShakeBase, decimal PriceL, decimal PriceM, decimal PriceS);
	public class ShakeBase
	{
		[BsonId]
		public Guid ShakeId { get; } = Guid.NewGuid();
		public string Name { get; set; }//because thay wanted the same name like the menue shakes
		public string Description { get; set; }
	}
}
