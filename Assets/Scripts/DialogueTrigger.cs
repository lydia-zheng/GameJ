using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

//	public string name;
//	public string dialogue;
	private DialogueManager DialogM;


	// Use this for initialization
	void Start () {
		DialogM = FindObjectOfType<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D thing){
		if (thing.gameObject.name == "MC" && Input.GetKeyUp (KeyCode.Space)) {
			//	DialogM.displayBox (name,dialogue);

			if (gameObject.name == "QueenTalk" ) {
				DialogM.displayBox ("Queen");
			}
			if (gameObject.name == "JokerTalk") {
				DialogM.displayBox ("Joker");
			}

		}
	}
}
