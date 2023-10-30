namespace RebarExercise.Models
{
	public class Menu
	{
		public List<Shake> Shakes { get; set; }
		public Menu()
		{
			Shakes = new List<Shake>();
			
		}

		public void addShake(Shake shake)
		{
			//take all shakes from database
			
			//add to database a shake
			Shakes.Add(shake);// add to this list 
			
			
		}
	}

	
}
