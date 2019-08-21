using BC.BattleStructure.Cards.Stats;

namespace BC.BattleStructure.Cards
{
	public class Base : Card
	{
		public BaseColor Color { get; private set; }

		public BaseStats Stats { get; set; }

		public Base(string name, BaseColor c) : base(name, CardType.Base)
		{
			Color = c;
		}
	}
}
