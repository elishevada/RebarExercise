using MongoDB.Bson.Serialization.Attributes;

namespace RebarExercise.Models
{
	public class OrderShake
	{
        //[BsonId]
        //public Guid OrderShakeId { get;} = Guid.NewGuid();
        //public ShakeBasicDetails ShakeBasicDetails { get; set; }
		public Shake? Shake { get; set; }//not null
        [BsonElement("shakeSize")]
        public Size ShakeSize { get; set; }
        [BsonElement("price")]
        public decimal Price { get; set; }
		public enum Size
		{
			Small,
			Medium,
			Large,
		}
	}
}
