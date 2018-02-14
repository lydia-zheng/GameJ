using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    public string levelName = "CityScene";
    private gameMaster gm;
    public bool usingDoor = false;

    void Start()
    {
        gm = FindObjectOfType<gameMaster>();   
    }

	void Update () {
		checkDoor ();
	}

	void checkDoor(){
		if (usingDoor && Input.GetKeyDown(KeyCode.E)) {
			SceneManager.LoadScene (levelName);
		}
	}


    void OnTriggerEnter2D(Collider2D coll)
    {
		if (coll.gameObject.name == "MC") {
			gm.InputText.text = ("Press [E] To Enter");
			usingDoor = true;
		} 

    }

    void OnTriggerExit2D(Collider2D coll)
    {
		if (coll.gameObject.name == "MC") {
            gm.InputText.text = ("");
			usingDoor = false;

        }
       
    }
}
