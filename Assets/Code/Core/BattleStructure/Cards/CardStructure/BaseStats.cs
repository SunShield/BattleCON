namespace BC.BattleStructure.Cards.Stats
{
	public class BaseStats
	{
		public Range Range { get; set; }
		public int Power { get; set; }
		public int Priority { get; set; }
		public int Guard { get; set; }
		public int Armor { get; set; }

		public static BaseStats operator +(BaseStats s1, BaseStats s2)
		{
			BaseStats stats = new BaseStats()
			{
				Range = s1.Range + s2.Range,
				Power = s1.Power + s2.Power,
				Priority = s1.Priority + s2.Priority,
				Guard = s1.Guard + s2.Guard,
				Armor = s1.Armor + s2.Armor
			};
			return stats;
		}
	}
}
