using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour {
    public int shards;
    public Text InputText;
    public Text ShardText;

    void Update()
    {
        ShardText.text = ("Shards: " + shards);
    }

}
