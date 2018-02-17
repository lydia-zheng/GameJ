using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    public string levelName = "";
    private gameMaster gm;
    public bool usingDoor = false;
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
		if (mc.IsTouching (door) && door.name == "Bed") {
			gm.EnterText.text = ("Press [E] To Sleep");
			usingDoor = true;
			if (Input.GetKeyDown (KeyCode.E)) {
				SceneManager.LoadScene (levelName);
			}
		} else if (mc.IsTouching (door)) {
			gm.EnterText.text = ("Press [E] To Enter");
			usingDoor = true;
			if (Input.GetKeyDown (KeyCode.E)) {
				SceneManager.LoadScene (levelName);
			}
		}else {
			gm.EnterText.text = ("");
				usingDoor = false;
		}
	}

}
