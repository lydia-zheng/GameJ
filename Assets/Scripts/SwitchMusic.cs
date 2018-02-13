using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusic : MonoBehaviour {

	public AudioClip newTrack;
	private AudioManager audioM;


	// Use this for initialization
	void Start () {
		audioM = FindObjectOfType<AudioManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D trigger){
		if (trigger.gameObject.name == "MC" || gameObject.name == "MusicTrigger") {
			if (newTrack != null) {
				audioM.ChangeBGM (newTrack);
			}
		}
				
	}

}

