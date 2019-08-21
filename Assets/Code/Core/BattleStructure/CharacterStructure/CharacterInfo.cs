using BC.BattleStructure.Cards;
using System.Collections.Generic;

namespace BC.BattleStructure.CharacterStructure
{
	public class CharacterInfo
	{
		public List<Base> UniqueBases = new List<Base>();
		public List<Style> Styles = new List<Style>();

		public CharacterInfo()
		{
			UniqueBases = FillUniqueBases();
			Styles = FillStyles();
		}

		#region Unique Bases

		protected virtual List<Base> FillUniqueBases()
		{
			List<Base> bases = new List<Base>
			{
				CreateUniqueBase()
			};

			return bases;
		}

		protected virtual Base CreateUniqueBase()
		{
			Base b = new Base("", BaseColor.Grey);
			return b;
		}

		#endregion

		#region Styles

		protected virtual List<Style> FillStyles()
		{
			List<Style> styles = new List<Style>
			{
				CreateRedStyle(),
				CreateOrangeStyle(),
				CreateYellowStyle(),
				CreateGreenStyle(),
				CreateBlueStyle()
			};

			return styles;
		}

		protected virtual Style CreateRedStyle()
		{
			Style s = new Style("", StyleColor.Red);
			return s;
		}

		protected virtual Style CreateOrangeStyle()
		{
			Style s = new Style("", StyleColor.Orange);
			return s;
		}

		protected virtual Style CreateYellowStyle()
		{
			Style s = new Style("", StyleColor.Yellow);
			return s;
		}

		protected virtual Style CreateGreenStyle()
		{
			Style s = new Style("", StyleColor.Green);
			return s;
		}

		protected virtual Style CreateBlueStyle()
		{
			Style s = new Style("", StyleColor.Blue);
			return s;
		}

		#endregion
	}
}
