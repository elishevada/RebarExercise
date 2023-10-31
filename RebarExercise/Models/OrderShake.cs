namespace RebarExercise.Models
{
	public class OrderShake
	{

		public ShakeBase Shake { get; set; }
		public Size ShakeSize { get; set; }	
		public decimal Price { get; set; }
		public enum Size
		{
			Small,
			Medium,
			Large,
		}
	}
}
