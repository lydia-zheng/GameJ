using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shard : MonoBehaviour {
    private gameMaster gm;

    // Update is called once per frame
     void Start()
    {
        gm = FindObjectOfType<gameMaster>();
    }
    private void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlayerMovement>())
        {
            gm.shards += 1;
            Destroy(gameObject);
            Update();
        }    
    }
}
