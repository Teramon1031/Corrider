using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	
	public float speed = 10;
	public float run = 1.5f;
	private float run2;

	public static float runPower = 1.0f;

	public float jumpPower = 500f;
	private Rigidbody _rigid;
	bool jumpflg = true;

	void Awake(){
		_rigid = this.GetComponent<Rigidbody> ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			if (runPower >= 0) {
				run2 = run;
				runPower -= 0.3f * Time.deltaTime;
			}
		} else { 
			run2 = 1;
		}
		if (runPower < 1f && run2 == 1) {
			runPower += 0.2f * Time.deltaTime;
		}
	
		transform.position += new Vector3 (0, 0, 1) * Time.deltaTime * speed  * run2;

		if (this.transform.position.y > 3) {
			jumpflg = false;
		} else { 
			jumpflg = true;
		}
		if (jumpflg == true) {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				this._rigid.AddForce (Vector3.up * jumpPower);
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.position += Vector3.right * 3.0f * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) { 
			this.transform.position += Vector3.left * 3.0f * Time.deltaTime;
		}
//		if (this.transform.position.z > 0) {
//			transform.position = new Vector3 (0, 2, -245);
//		}

	}
	void OnTriggerEnter(Collider col) { 
		if (col.gameObject.tag == "Goal") {
			SceneManager.LoadScene ("Goal");
		}
	}

}
