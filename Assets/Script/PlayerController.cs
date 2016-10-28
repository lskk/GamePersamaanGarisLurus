using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float maxSpeed = 10f;
	bool ngadepKanan = true;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.right * maxSpeed * Time.deltaTime);
			if (ngadepKanan != true) {
				Flip ();
			}
		} else if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector2.right * maxSpeed * Time.deltaTime);
			if (ngadepKanan == true) {
				Flip ();
			}
		} else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector2.down * maxSpeed * Time.deltaTime);
		} else if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector2.up * maxSpeed * Time.deltaTime);
		}
	}

	void Flip () {
		ngadepKanan = !ngadepKanan;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}
}
