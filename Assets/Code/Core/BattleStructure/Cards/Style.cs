using BC.BattleStructure.Cards.Stats;

namespace BC.BattleStructure.Cards
{
	public class Style : Card
	{
		public StyleColor Color { get; private set; }

		public BaseStats Stats { get; set; }

		public Style(string name, StyleColor c) : base(name, CardType.Style)
		{
			Color = c;
		}
	}
}
