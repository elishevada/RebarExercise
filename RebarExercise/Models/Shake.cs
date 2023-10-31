using MongoDB.Bson.Serialization.Attributes;
using System.Drawing;

namespace RebarExercise.Models
{

	//public record MenuShakeR(Shake MenuShake, [BsonId]  Guid MenuShakeId,double PriceL,double PriceM,double PriceS );
	public record OrderShakeR(Shake OrderShake,double Price, Guid OrderShakeId);
	public class Shake
	{
		
		public string Name { get; set; }//because thay wanted the same name like the menue shakes
		public string Description { get; set; }

	}
}
