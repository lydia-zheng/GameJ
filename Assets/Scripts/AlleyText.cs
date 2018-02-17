using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AlleyText : MonoBehaviour {

	private gameMaster gm;
	public Collider2D mc;
	public Collider2D door;

	void Start()
	{
		gm = FindObjectOfType<gameMaster>();
		mc = GameObject.FindGameObjectWithTag ("Player").GetComponent<Collider2D>();
		door = gameObject.GetComponent<Collider2D>();
	}

	void Update () {
		checkDoor ();
	}

	void checkDoor(){
		if (mc.IsTouching (door) && door.name == "Alley") {
			gm.EnterText.text = ("Press [E] To Enter");
		}else {
			gm.EnterText.text = ("");
		}
	}

}
