namespace RebarExercise.Models
{
	public class Menu
	{
		public List<MenuShake> MenuShakes { get; set; }
		public Menu()
		{
			MenuShakes = new List<MenuShake>();
			
		}

		public void addShake(MenuShake shake)
		{
			//take all shakes from database

			//add to database a shake
			MenuShakes.Add(shake);// add to this list 
			
			
		}
	}

	
}
