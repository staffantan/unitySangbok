using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollClickFix : MonoBehaviour {
	[SerializeField]
	private float _maxDistance;

	private Vector2 _startPosition;

	public void OnBeginDrag(PointerEventData data)
	{
		_startPosition = data.position;
	}

	public void OnEndDrag(PointerEventData data)
	{

		float distance = Vector2.Distance(_startPosition, data.position);

		if (distance < _maxDistance)
		{
			//data.pointerPressRaycast.go.GetComponent<YourComponent>().OnClickMethod();
		}
	}
}
