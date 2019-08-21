using UnityEngine;

public class MonoBehaviourE : MonoBehaviour
{
	private Transform _transform;
	public Transform Tran
	{
		get
		{
			if (_transform == null)
				CacheTransform();
			return _transform;
		}
	}

	private void CacheTransform()
	{
		_transform = transform;
	}
}
