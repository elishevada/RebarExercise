namespace RebarExercise.Models
{
	public class Account
	{
		
		public double OrdersTotal { get; set; }
		public List<Order> Orders { get; set; }
		public Account()
		{
			
			Orders = new List<Order>();
			//take all orders from db
			foreach(var order in Orders)
			{
				//OrdersTotal+=
			}
		}
	}
}
