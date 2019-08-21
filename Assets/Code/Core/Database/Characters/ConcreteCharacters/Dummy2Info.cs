using BC.BattleStructure;
using BC.BattleStructure.Cards;
using BC.BattleStructure.Cards.Stats;
using BC.BattleStructure.CharacterStructure;

namespace BC.Database.UCharacter
{
	public class Dummy2Info : CharacterInfo
	{
		#region Unique Bases

		protected override Base CreateUniqueBase()
		{
			Base b = new Base("Base", BaseColor.Grey);
			b.Stats = new BaseStats()
			{
				Range = new Range(1, 2),
				Power = 4,
				Priority = 1,
				Guard = 2,
				Armor = 1
			};
			return b;
		}

		#endregion

		#region Styles

		protected override Style CreateRedStyle()
		{
			Style s = new Style("Red", StyleColor.Red);
			s.Stats = new BaseStats()
			{
				Range = new Range(0, 0),
				Power = 0,
				Priority = 1,
				Guard = 2,
				Armor = 0
			};
			return s;
		}

		protected override Style CreateOrangeStyle()
		{
			Style s = new Style("Orange", StyleColor.Orange);
			s.Stats = new BaseStats()
			{
				Range = new Range(0, 1),
				Power = -1,
				Priority = 1,
				Guard = 0,
				Armor = 0
			};
			return s;
		}

		protected override Style CreateYellowStyle()
		{
			Style s = new Style("Yellow", StyleColor.Yellow);
			s.Stats = new BaseStats()
			{
				Range = new Range(1, 2),
				Power = 0,
				Priority = 1,
				Guard = 0,
				Armor = 1
			};
			return s;
		}

		protected override Style CreateGreenStyle()
		{
			Style s = new Style("Green", StyleColor.Green);
			s.Stats = new BaseStats()
			{
				Range = new Range(1, 3),
				Power = -1,
				Priority = -1,
				Guard = 3,
				Armor = 0
			};
			return s;
		}

		protected override Style CreateBlueStyle()
		{
			Style s = new Style("Blue", StyleColor.Blue);
			s.Stats = new BaseStats()
			{
				Range = new Range(1, 1),
				Power = -1,
				Priority = -2,
				Guard = 0,
				Armor = 2
			};
			return s;
		}

		#endregion
	}
}
