using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public GameObject target;
	public float cameraSpeed;
	private Vector3 targetPos;

	private 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		targetPos = new Vector3 (target.transform.position.x, target.transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, targetPos, cameraSpeed * Time.deltaTime);
	}
}
