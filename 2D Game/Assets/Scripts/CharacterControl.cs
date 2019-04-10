﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	//player movement variables
	public float moveSpeed;
	public float jumpHeight;

	//Player grounded variables
	public bool grounded;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatisGround;


	// Use this for initialization
	void Start () {
		
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
		}
		else if (Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
		}
		
		//Makes player jump
		 if (Input.GetKeyDown(KeyCode.W) && grounded){
			Jump();

		}
		if(GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(5f,5f,1f);

		else if(GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-5f,5f,1f);	
			
			}
		
		void Jump(){
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);	
		}
}
