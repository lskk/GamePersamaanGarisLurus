using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;
	public PlayerController pCon;

	public bool dialogActive;

	// Use this for initialization
	void Start () {
		pCon = FindObjectOfType<PlayerController> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (dialogActive && Input.GetKeyDown (KeyCode.Return)) {
			dBox.SetActive (false);
			dialogActive = false;
			pCon.enabled = true;
		}
	}

	public void ShowBox(string dialog){
		pCon.enabled = false;
		dialogActive = true;
		dBox.SetActive (true);
		dText.text = dialog;
	}
}
