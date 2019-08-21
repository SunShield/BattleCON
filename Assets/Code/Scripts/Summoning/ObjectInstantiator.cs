using BC.UField.Structure;
using BC.Service;
using UnityEngine;
using BC.UCharacter;

namespace BC.UnityCore
{
	public class ObjectInstantiator : MonoSingleton<ObjectInstantiator>
	{
		[SerializeField] private GameObject TilePrefab;
		[SerializeField] private GameObject CharacterPrefab;

		public Tile InstantiateTile(Transform parent, int tileCoord)
		{
			GameObject go = Instantiate(TilePrefab);
			go.name = string.Format("[Tile ({0})]", tileCoord);
			go.transform.parent = parent;
			Tile tile = go.GetComponent<Tile>();
			return tile;
		}

		// later add sprites here?
		public Character InstantiateCharacter(string characterName)
		{
			GameObject go = Instantiate(CharacterPrefab);
			go.name = characterName;
			Character c = go.AddComponent<Character>();
			return c;
		}
	}
}
