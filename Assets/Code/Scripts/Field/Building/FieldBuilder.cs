using BC.Service;
using BC.UField.Structure;
using BC.UnityCore;
using System.Collections.Generic;
using UnityEngine;

namespace BC.UField.Building
{
	public class FieldBuilder : MonoSingleton<FieldBuilder>
	{
		public Field BuildField(GameObject fieldGO, int fieldLength)
		{
			List<Tile> tiles = ConstructTiles(fieldGO, fieldLength);
			Field field = fieldGO.AddComponent<Field>();
			field.Init(tiles);
			return field;
		}

		private List<Tile> ConstructTiles(GameObject fieldGO, int amount)
		{
			List<Tile> tiles = new List<Tile>();

			float leftmostTileX = GetLeftmostTileX(amount);
			for (int i = 0; i < amount; i++)
			{
				Tile t = InstantiateTile(fieldGO, i);
				SetTilePosition(t, leftmostTileX, i);
				tiles.Add(t);
			}

			return tiles;
		}

		private float GetLeftmostTileX(int amount)
		{
			return -Constants.TileX * (amount - 1) / 2;
		}

		private Tile InstantiateTile(GameObject fieldGO, int tileIndex)
		{
			Tile tile = ObjectInstantiator.Instance.InstantiateTile(fieldGO.transform, tileIndex);
			tile.Init(tileIndex);
			return tile;
		}

		private void SetTilePosition(Tile t, float leftmostTileX, int tileIndex)
		{
			t.transform.localPosition = new Vector3(leftmostTileX + tileIndex * Constants.TileX, 0f, 0f);
		}
	}
}
