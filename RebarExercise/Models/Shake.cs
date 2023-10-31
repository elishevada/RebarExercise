using MongoDB.Bson.Serialization.Attributes;
using System.Drawing;

namespace RebarExercise.Models
{

	public class Shake
	{
		public ShakeBase ShakeBase { get; set; }
        [BsonElement("PriceL")]
        public decimal PriceL { get; set; }
		public decimal PriceM { get; set; }
		public decimal PriceS { get; set; }

	}
}
