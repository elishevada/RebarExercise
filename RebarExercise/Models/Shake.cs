namespace RebarExercise.Models
{
	public class Shake
	{
		public Guid ShakeId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		//public Sizes Size { get; set; }
		public double PriceL { get; set; }
		public double PriceM { get; set; }
		public double PriceS { get; set; }

		//public enum Sizes
		//{
		//	L,
		//	M,
		//	S,
		//}
		public Shake(string name,string description,double priceL, double priceM, double priceS) {
			ShakeId = Guid.NewGuid();
			Name = name;
			Description = description;
			PriceL = priceL;
			PriceM = priceM;
			PriceS = priceS;
		}
			

	}
}
