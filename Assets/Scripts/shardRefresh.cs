using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shardRefresh : MonoBehaviour {
	public gameMaster GM;

	// Use this for initialization
	void Start () {
		GM = FindObjectOfType<gameMaster>();
	}

	// Update is called once per frame
	void Update () {
	}

	void refreshShard(){
		GM.shards = 0;

	}

	void OnTriggerEnter2D(Collider2D thing)
	{
		if (thing.gameObject.name == "MC") {
			refreshShard ();
		} 

	}
	void OnTriggerExit2D(Collider2D thing)
	{
		if (thing.gameObject.name == "MC") {
			Destroy (gameObject);
		} 

	}
}
