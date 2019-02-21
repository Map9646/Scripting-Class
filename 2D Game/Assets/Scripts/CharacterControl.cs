﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	//player movement variables
	public float moveSpeed;
	public float jumpHeight;

	//Player grounded variables
	public bool grounded;


	// Use this for initialization
	void Start () {
		
	grounded = true;
	}
	//Logic Operators
	
	/*This && (and) that
	this || (or) that
	 !(Not this)*/
	
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
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
		}
	}
}
