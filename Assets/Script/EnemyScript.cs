using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public float speed2 = 11;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0, 0, 1) * Time.deltaTime * speed2; 
	}
}
