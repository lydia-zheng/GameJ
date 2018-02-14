using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

//	public string name;
//	public string dialogue;
	private DialogueManager DialogM;
	public bool canTalk;


	// Use this for initialization
	void Start () {
		DialogM = FindObjectOfType<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
	 talkingTo();
	}

	void talkingTo(){
		if (canTalk && Input.GetKeyUp (KeyCode.Space)) {

			if (gameObject.name == "Mother") {
				DialogM.currNPC = "Mother";

			}
			if (gameObject.name == "Bag") {
				DialogM.currNPC = "Bag";

			}
			if (gameObject.name == "Police") {
				DialogM.currNPC = "Police";
			}
			if (gameObject.name == "Crayon") {
				DialogM.currNPC = "Crayon";

			}
			if (gameObject.name == "Detective") {
				DialogM.currNPC = "Detective";
			}
			if (gameObject.name == "Letter") {
				DialogM.currNPC = "Letter";
			}
			if (gameObject.name == "Sister") {
				DialogM.currNPC = "Sister";
			}
			if (gameObject.name == "Doge") {
				DialogM.currNPC = "Doge";
			}
			if (gameObject.name == "Scarf")
			{
				DialogM.currNPC = "Scarf";
			}


		}
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
        if (thing.gameObject.name == "MC")
        {
            if (gameObject.name == "LastSceneDialogue")
            {
                DialogM.displayBox();
                DialogM.currNPC = "LastSceneDialogue";

            }
        }
		if (thing.gameObject.name == "MC") {
			canTalk = true;
		} 


    }

	void OnTriggerExit2D(Collider2D thing)
	{
		if (thing.gameObject.name == "MC") {
			canTalk = false;
		} 

	}
		
}
