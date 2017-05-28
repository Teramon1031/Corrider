using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GageScript : MonoBehaviour {

	private RectTransform _rectTransform;
	private float t;
	private float maxValue;

	private Vector2 gageVector2;

	void Awake () {
		
		_rectTransform = transform.FindChild ("Gage").gameObject.GetComponent<RectTransform> ();
		maxValue = _rectTransform.sizeDelta.x;
		t = 1f;
	}

	private void UpdateValue (){
		float x = Mathf.Lerp (0f, maxValue, t);
		_rectTransform.sizeDelta = new Vector2 (x, _rectTransform.sizeDelta.y);
	}
	
	// Update is called once per frame
	void Update () {
		t = PlayerScript.runPower;
		
		UpdateValue ();

//		if (t <= 0f) {
//			t = 1f;
//		}
	}
}
