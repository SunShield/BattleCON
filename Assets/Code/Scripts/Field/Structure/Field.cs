using System.Collections.Generic;
using UnityEngine;

namespace BC.UField.Structure
{
	public class Field : MonoBehaviour
	{
		private List<Tile> _tiles;

		public int Length {  get { return _tiles.Count; } }

		public Tile this[int index]
		{
			get { return _tiles[index]; }
		}

		public void Init(List<Tile> tiles)
		{
			_tiles = tiles;
		}
	}
}
