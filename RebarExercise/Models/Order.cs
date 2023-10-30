namespace RebarExercise.Models
{
	public class Order
	{
		public Guid OrderId { get; set; }
		public string customersName { get; set; }
		public DateTime OrderDate { get; set; }
		public List<Shake> Shakes { get; set;}//i need a list of shakes or list of id of shakes 
		public double TotalShakes { get; set; }
		
	}
}
