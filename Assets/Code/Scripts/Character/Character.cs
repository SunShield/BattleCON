using BC.Players;
using BC.UField.Structure;
using UnityEngine;

namespace BC.UCharacter
{
	public class Character : MonoBehaviourE
	{
		public Tile Tile { get; set; }
		public Player Owner { get; private set; }

		public string Name { get; set; }
		public int Health { get; set; }

		public BattleStructure.CharacterStructure.CharacterInfo Info { get; private set; }

		public void Init(Player owner, BattleStructure.CharacterStructure.CharacterInfo info)
		{
			Owner = owner;
			Info = info;
		}

		public void BoundToTile(Tile newTile)
		{
			Tile = newTile;
			Tran.parent = newTile.transform;
			Tran.localPosition = Vector3.zero;
			newTile.SetCharacter(this);
		}
	}
}
