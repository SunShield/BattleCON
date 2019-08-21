using BC.UCharacter;
using UnityEngine;

namespace BC.UField.Structure
{
	public class Tile : MonoBehaviour
	{
		[SerializeField] private int _coord;

		public Character Character { get; private set; } 
		public bool ContainsCharacter { get { return Character != null; } }

		public void Init(int coord)
		{
			_coord = coord;
		}

		// could be useful to call on-enter effects there?..
		public void SetCharacter(Character c)
		{
			Character = c;
		}
	}
}
