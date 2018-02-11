using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnDoor : MonoBehaviour {


    public string levelName = "CitySceneExit";
    private gameMaster gm;

    bool isLoadingScene = false;

    void Start()
    {
        gm = FindObjectOfType<gameMaster>();
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.GetComponent<PlayerMovement>())
        {

            if (!isLoadingScene)
            {
                isLoadingScene = true;
                SceneManager.LoadScene(levelName);
            }
               

            
        }
    }
    
    }
 



