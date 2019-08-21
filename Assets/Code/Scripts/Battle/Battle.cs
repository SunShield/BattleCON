using BC.Database.UCharacter;
using BC.Players;
using BC.UCharacter;
using BC.UCharacter.Building;
using BC.UField.Building;
using BC.UField.Structure;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
	[SerializeField] private GameObject FieldGo;
	[SerializeField] private int fieldSize;
	[SerializeField] private string Char1Name;
	[SerializeField] private string Char2Name;

	private Field _field;
	private List<Character> _characters = new List<Character>();
	private List<Player> _players = new List<Player>();

	// TEMPORARY DOING IT IN START
	private void Start()
	{
		BuildField();
		CreatePlayers();
		CreateCharacters();
	}

	private void BuildField()
	{
		_field = FieldBuilder.Instance.BuildField(FieldGo, fieldSize);
	}

	private void CreatePlayers()
	{
		Player p1 = new Player("player1");
		_players.Add(p1);
		Player p2 = new Player("player2");
		_players.Add(p2);
	}

	private void CreateCharacters()
	{
		BuildCharacter(_players[0], "Dummy1", 2);
		BuildCharacter(_players[1], "Dummy2", 4);
	}

	private void BuildCharacter(Player owner, string name, int startingPosition) // for now
	{
		var character = CharacterBuilder.Instance.BuildCharacter(_field, owner, name, startingPosition);
		_characters.Add(character);
	}
}
