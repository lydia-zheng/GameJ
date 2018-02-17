using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameMaster : MonoBehaviour {
    public int shards = 0;
	private string shardString = "0";
    public Text EnterText;
    public Text ShardText;
	public bool shardOn = true;

	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	}

    void Update()
    {
		if (shardOn == false) {
			ShardText.text = ("");
		} else if (shardOn == true) {
			shardString = shards.ToString ();
			ShardText.text = (shardString + "/2 memories");
		}
    }


}
