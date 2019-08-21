using BC.BattleStructure.CharacterStructure;
using System.Collections.Generic;

namespace BC.Database.UCharacter
{
	public class CharacterDatabase
	{
		private Dictionary<string, CharacterInfo> _infos = new Dictionary<string, CharacterInfo>();

		public CharacterDatabase()
		{
			FillInfo();
		}

		private void FillInfo()
		{
			_infos.Add("Dummy1", new Dummy1Info());
			_infos.Add("Dummy2", new Dummy2Info());
		}

		public CharacterInfo this[string characterName]
		{
			get { return _infos[characterName]; }
		}
	}
}
