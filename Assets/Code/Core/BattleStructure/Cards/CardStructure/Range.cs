namespace BC.BattleStructure.Cards.Stats
{ 
	public class Range
	{
		public int MinRange { get; set; }
		public int MaxRange { get; set; }

		public Range(int min, int max)
		{
			MinRange = min;
			MaxRange = max;
		}

		public static Range operator +(Range r1, Range r2)
		{
			Range r = new Range(r1.MinRange + r2.MinRange, r1.MinRange + r2.MaxRange);
			return r;
		}
	}
}
