using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public int playerSpeed = 10;
	public bool facingRight = true;
	public int jumpPower = 1300;
	public float moveX;

	// Use this for initialization
	//	void Start () {

	//	}

	// Update is called once per frame
	void Update () {
		PlayerMove ();
	}

	void PlayerMove(){
		moveX = Input.GetAxis("Horizontal");

		if (Input.GetKeyDown(KeyCode.UpArrow)){
			Jump();
		}

		if (moveX != 0) {
			gameObject.GetComponent<Animator> ().SetBool ("isRunning", true);
		} else {
			gameObject.GetComponent<Animator> ().SetBool ("isRunning", false);
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
