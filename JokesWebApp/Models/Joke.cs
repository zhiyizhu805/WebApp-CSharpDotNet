using System;
namespace JokesWebApp.Models
{
	public class Joke
	{
		    // prop shortcut to generate prop
			public int Id { get; set; }
		    public string JokeQuestion { get; set; }
		    public string JokeAnswer { get; set; }

		// ctor shortcut to generate method
		public Joke()
		{

		}

	}
}

