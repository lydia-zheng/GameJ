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

	void OnTriggerEnter2D(Collider2D thing){
		if (thing.gameObject.name == "MC") {
			if (gameObject.name == "FirstSceneDialogue") {
				DialogM.displayBox ();
				DialogM.currNPC = "FirstSceneDialogue";

			}
		}
		if (thing.gameObject.name == "MC") {
			if (gameObject.name == "DarkSceneDialogue") {
				DialogM.displayBox ();
				DialogM.currNPC = "DarkSceneDialogue";

			}
		}
	}

	void OnTriggerStay2D(Collider2D thing){

	
		if (thing.gameObject.name == "MC" && Input.GetKeyUp (KeyCode.Space)) {

			if (gameObject.name == "Mother") {
				DialogM.displayBox ();
				DialogM.currNPC = "Mother";

			}
			if (gameObject.name == "Bag") {
				DialogM.displayBox ();
				DialogM.currNPC = "Bag";

			}
			if (gameObject.name == "Police") {
				DialogM.displayBox ();
				DialogM.currNPC = "Police";
			}
			if (gameObject.name == "Crayon") {
				DialogM.displayBox ();
				DialogM.currNPC = "Crayon";

			}
			if (gameObject.name == "Detective") {
                print("hello");
				DialogM.displayBox ();
				DialogM.currNPC = "Detective";
			}
			if (gameObject.name == "Letter") {
				DialogM.displayBox ();
				DialogM.currNPC = "Letter";
			}
			if (gameObject.name == "Sister") {
				DialogM.displayBox ();
				DialogM.currNPC = "Sister";
			}
			if (gameObject.name == "Doge") {
				DialogM.displayBox ();
				DialogM.currNPC = "Doge";
			}
            if (gameObject.name == "Scarf")
            {
                DialogM.displayBox();
                DialogM.currNPC = "Scarf";
            }

        }
	}
}
