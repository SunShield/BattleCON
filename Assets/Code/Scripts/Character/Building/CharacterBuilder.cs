using BC.Database.UCharacter;
using BC.Players;
using BC.Service;
using BC.UField.Structure;
using BC.UnityCore;

namespace BC.UCharacter.Building
{
	// Not sure this class is necessary. Let's leave it for now (for the case if later character gameobject will become more complicated and configurable).
	public class CharacterBuilder : MonoSingleton<CharacterBuilder>
	{
		private CharacterDatabase _database = new CharacterDatabase();

		public Character BuildCharacter(Field field, Player owner, string characterName, int characterCoord)
		{
			Tile characterTile = GetCharacterTile(field, characterCoord);
			Character newCharacter = InstantiateCharacterObject(characterName);
			BoundCharacterToTile(characterTile, newCharacter);

			SetCharacterData(owner, characterName, newCharacter);
			return newCharacter;
		}

		private Tile GetCharacterTile(Field field, int characterCoord)
		{
			return field[characterCoord];
		}

		private Character InstantiateCharacterObject(string characterName)
		{
			return ObjectInstantiator.Instance.InstantiateCharacter(characterName);
		}

		private void BoundCharacterToTile(Tile characterTile, Character newCharacter)
		{
			newCharacter.BoundToTile(characterTile);
		}

		private void SetCharacterData(Player owner, string characterName, Character newCharacter)
		{
			newCharacter.Name = characterName;
			newCharacter.Health = 20; // default. alternative starting health should be set by UA?.. Like PrepareCharacter() method?..
			newCharacter.Init(owner, _database[characterName]);
		}
	}
}
