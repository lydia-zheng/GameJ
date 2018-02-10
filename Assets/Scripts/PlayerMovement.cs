using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	// YANS FARTY ADDITION
	public int playerSpeed = 5;
	public bool facingRight = true;
	public int jumpPower = 5;
	public float moveX;
	private bool inAir = false;

	// Use this for initialization
//	void Start () {

//	}
	
	// Update is called once per frame
	void Update () {
		PlayerMove ();
	}

	void PlayerMove(){
		moveX = Input.GetAxis("Horizontal");

		if (Input.GetButtonDown("Jump") && !inAir){
			Jump();
		}

		if (moveX < 0.0f && facingRight == true){
			flipPlayer();
		}else if(moveX > 0.0f && facingRight == false){
			flipPlayer();
		}

		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2(playerSpeed * moveX, gameObject.GetComponent<Rigidbody2D> ().velocity.y);
	}

	void Jump(){
		gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpPower));
	}
	void flipPlayer(){
		facingRight = !facingRight;
		transform.localScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);
	}
}
//COMMENTED 