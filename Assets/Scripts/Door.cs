using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    public string levelName = "CityScene";
    private gameMaster gm;

    bool isLoadingScene = false;

    void Start()
    {
        gm = FindObjectOfType<gameMaster>();   
    }

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.GetComponent<PlayerMovement>())
        {
            gm.InputText.text = ("Press [E] To Enter");
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
		if (coll.gameObject.name == "MC" && Input.GetKeyDown(KeyCode.E)) {
				SceneManager.LoadScene (levelName);
		}
			
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll)
        {
            gm.InputText.text = ("");

        }
       
    }
}
