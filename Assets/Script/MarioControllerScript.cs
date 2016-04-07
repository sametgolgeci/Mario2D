using UnityEngine;
using System.Collections;


public class MarioControllerScript : MonoBehaviour {

	public float speed = 2f;
	public float jumpSpeed = 10f;
	public Rigidbody2D body;
	public LayerMask GroundLayers;
	public static int playerState;

	private Animator marioAnimator;
	private Transform groundCheck;

	void Start () {
		marioAnimator = GetComponent<Animator> ();
		body = GetComponent<Rigidbody2D> ();

		groundCheck = transform.FindChild ("GroundCheck");

		playerState = 0;
	}

	void FixedUpdate () {
		bool isGrounded = Physics2D.OverlapPoint (groundCheck.position, GroundLayers);
		if (Input.GetButton ("Jump")) {
			
			if (isGrounded) {
				body.AddForce (Vector3.up * jumpSpeed, ForceMode2D.Impulse);
				isGrounded = false;
			}

		}
		marioAnimator.SetBool ("IsGrounded", isGrounded );
		float hSpeed = Input.GetAxis ("Horizontal");
		marioAnimator.SetFloat ("Speed", Mathf.Abs (hSpeed));
		if (hSpeed < 0) {
			transform.localScale = new Vector3 (-1, 1, 1);
		} else if (hSpeed > 0) {
			transform.localScale = new Vector3 (1, 1, 1);
		}
		body.velocity = new Vector2 (hSpeed * speed, body.velocity.y);
	}
}