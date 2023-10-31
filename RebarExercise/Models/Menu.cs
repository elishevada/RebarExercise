namespace RebarExercise.Models
{
	public class Menu
	{
		public List<Shake> Shake { get; set; }
		public Menu()
		{
			Shake = new List<Shake>();
			
		}

		public void addShake(Shake shake)
		{
			//take all shakes from database

			//add to database a shake
			Shake.Add(shake);// add to this list 
			
			
		}
	}

	
}
