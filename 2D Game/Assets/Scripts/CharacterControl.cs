using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	//player movement variables
	public float moveSpeed;
	public float jumpHeight;
	private bool doubleJump;

	//Player grounded variables
	public bool grounded;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatisGround;

	//Non Slide Player
	private float moveVelocity;

	//Animations
	public Animator animator;


	// Use this for initialization
	void Start () {

		animator.SetBool("is Walking", false);
		animator.SetBool("is Jumping",false);
		
	grounded = true;
	}


	
	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatisGround);
	}
	
	// Update is called once per frame
	void Update () {
		//Moves Player left and right
		if (Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = moveSpeed;
			animator.SetBool("is Walking",true);

		}
		else if (Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -moveSpeed;
			animator.SetBool("is Walking",true);
		}
		else animator.SetBool("is Walking", false);

		
		
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity,GetComponent<Rigidbody2D>().velocity.y);
		
		
		//Makes player jump
		 if (Input.GetKeyDown(KeyCode.W) && grounded){
			Jump();
			animator.SetBool("is Jumping", true);


		}else animator.SetBool("is Jumping", false);
		if(GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(0.6f,0.6f,1f);

		else if(GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-0.6f,0.6f,1f);	

			//double jump

			if(grounded){
				doubleJump = false;
			
			}

			if(Input.GetKeyDown (KeyCode.W) && !doubleJump && !grounded){
				Jump();
				doubleJump = true;
			}

			//Player Flip
			if(GetComponent<Rigidbody2D>().velocity.x > 0)
				transform.localScale = new Vector3(0.6f,0.6f,1f);

			else if( GetComponent<Rigidbody2D>().velocity.x < 0)
				transform.localScale = new Vector3(-0.6f,0.6f,1f);

			//So Player does not Slide

			moveVelocity = 0f;		

			
			}
			
		
		void Jump(){
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);	
			animator.SetBool("is Jumping",true);
		}

}
