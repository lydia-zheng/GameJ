using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;
	public Text dName;
	public bool dialogActive;

	GameObject textObject;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (dialogActive && Input.GetKeyDown (KeyCode.Space)) {
		dBox.SetActive (false);
		dialogActive = false;
		}


	}

	//public void displayBox(string name, string dialogue){
	public void displayBox(string name){
		dBox.SetActive(true);
		dialogActive = true;

		if (name == "Joker"){
			dName.text = "Joker";
			dText.text = "My life is a joke.";
		}else if (name == "Queen"){
			dName.text = "Queen";
			dText.text = "I wish Joker took some antidepressants.";
		}

	}

	
}
