using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
	public AudioSource BGM;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeBGM(AudioClip music){
		if (BGM.clip.name == music.name) {
			return;
		}
		BGM.Stop ();
		BGM.clip = music;
		BGM.Play ();
	}

	/*IEnumerator FadeAudio(){
		while(BGM.volume > 0){
			BGM.volume = Mathf.Lerp (BGM.volume, 0, .1f);
		}
	}*/

	//StartCoroutine(FadeAudio());
}
