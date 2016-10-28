using UnityEngine;
using System.Collections;

public class Tabrakan : MonoBehaviour {


	void OnCollisionEnter2D (Collision2D col) {
		
		if (col.gameObject.name == "rak") {
			Destroy (col.gameObject);

		}
	}
}
