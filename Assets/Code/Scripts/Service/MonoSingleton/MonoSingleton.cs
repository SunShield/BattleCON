using UnityEngine;

namespace BC.Service
{
	public class MonoSingleton<T> : MonoBehaviourE where T: MonoBehaviourE
	{
		private static bool _shuttingDown = false;
		private static object _lock = new object();
		private static T _instance;

		public static T Instance
		{
			get
			{
				if (_shuttingDown)
					return null;

				lock (_lock)
				{
					if (_instance == null)
						_instance = FindInstance();
						
					if (_instance == null)
						_instance = CreateInstance();

					return _instance;
				}
			}
		}

		private static T FindInstance()
		{
			return (T)FindObjectOfType(typeof(T));
		}

		private static T CreateInstance()
		{
			var newGo = new GameObject();
			T component = newGo.AddComponent<T>();
			return component;
		}

		private void OnApplicationQuit()
		{
			_shuttingDown = true;
		}

		private void OnDestroy()
		{
			_shuttingDown = true;
		}
	}
}
