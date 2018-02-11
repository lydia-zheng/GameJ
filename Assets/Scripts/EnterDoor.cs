using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D trigger){
		if (trigger.gameObject.name == "MC" && Input.GetKeyUp (KeyCode.Space)) {
			SceneManager.LoadScene ("CityScene");
			}

		}
}
