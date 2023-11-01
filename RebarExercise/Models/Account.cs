namespace RebarExercise.Models
{
	public class Account
	{
		
		public decimal OrdersTotal { get; set; }
		public List<Order>? Orders { get; set; }
		
	}
}
