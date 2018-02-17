using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shardToggle : MonoBehaviour {
//	public GameObject shardDisplay;
	public gameMaster GM;

	// Use this for initialization
	void Start () {
		GM = FindObjectOfType<gameMaster>();
	}
	
	// Update is called once per frame
	void Update () {
		//shardDisplay = GameObject.Find ("Canvas/GameText/ShardText");
	}

	void toggleShard(){
		if (GM.shardOn == false) {
			GM.shardOn = true;
		}
		else if (GM.shardOn == true) {
			GM.shardOn = false;
		}

	}

	void OnTriggerEnter2D(Collider2D thing)
	{
		if (thing.gameObject.name == "MC") {
			toggleShard ();
		} 

	}
	void OnTriggerExit2D(Collider2D thing)
	{
		if (thing.gameObject.name == "MC") {
			Destroy (gameObject);
		} 

	}
}
