namespace BC.BattleStructure.Cards
{
	public class Card
	{
		public CardType Type { get; private set; }
		public string Name { get; set; }

		public Card(string name, CardType type)
		{
			Type = type;
		}
	}
}
