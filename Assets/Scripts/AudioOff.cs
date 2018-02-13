using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOff : MonoBehaviour {

	private AudioManager audioM;
	private AudioSource audioS;

	// Use this for initialization
	void Start () {
		audioM = FindObjectOfType<AudioManager> ();
		audioS = FindObjectOfType<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D trigger){
			Destroy (audioM);
			Destroy (audioS);
	}

}

