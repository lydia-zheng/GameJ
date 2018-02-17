using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shard : MonoBehaviour {
    private gameMaster gm;
    public DialogueManager dm;

    // Update is called once per frame
     void Start()
    {
        gm = FindObjectOfType<gameMaster>();
    }
    private void Update()
    {
        
    }

    public void DestroyShard()
    {
        gm.shards += 1;
        Destroy(gameObject);
    	Update();
    }
   


}    

