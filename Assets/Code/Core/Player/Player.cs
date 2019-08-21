using BC.UCharacter;
using System.Collections.Generic;

namespace BC.Players
{
	public class Player
	{
		public string Name { get; private set; }
		public List<Character> Characters { get; set; }

		public Player(string name)
		{
			Name = name;
		}
	}
}
