using UnityEngine;
using System.Collections;

public class DialogHolder : MonoBehaviour {

	public string dialog;
	private DialogManager dMan;


	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialogManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D (Collider2D col){
		if (col.gameObject.name == "chula") {
			if (Input.GetKeyDown (KeyCode.Space)) {
				dMan.ShowBox (dialog);

			}
		}
	}
}
