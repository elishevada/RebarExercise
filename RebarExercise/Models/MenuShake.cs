using MongoDB.Bson.Serialization.Attributes;

namespace RebarExercise.Models
{
	
	public class MenuShake
	{
		[BsonId]
		public Guid ShakeId { get; set; }
		public double PriceL { get; set; }
		public double PriceM { get; set; }
		public double PriceS { get; set; }
		public Shake Shake { get; set; }

		//public enum Sizes
		//{
		//	L,
		//	M,
		//	S,
		//}
		public MenuShake(Shake shake, double priceL, double priceM, double priceS) {
			ShakeId = Guid.NewGuid();
			PriceL = priceL;
			PriceM = priceM;
			PriceS = priceS;
			Shake= shake;
		}
			

	}
}
