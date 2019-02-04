using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {
	// Variables
	public int number;
	public float speed;
	public string name;

	// Use this for initialization
	void Start (){
		/*
		This 
		is 
		a 
		multiline
		comment
		 */
		//number = 10;
		speed = 0.94f;
		name = "Bob";
		number = 20;
		
		print(name +" is"+number+" years old"+ speed);
		/*
		New
		Multiline text 
		for practice*/
		
		speed = 1.2f;
		name = "Jimmy";
		number = 15
		
		print(name+"is"+ number+"years old");
		print(name+"is very fast"+ speed);
		/*
		Practice 
		makes
		perfect! */

		speed = 0.2f;
		name = "turtle";
		number = 1;

		print(name+ "is"+ number + "foot long")
		print(name+"is very slow"+ speed)
	}
		
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(number,0,0);
			
	}
}
