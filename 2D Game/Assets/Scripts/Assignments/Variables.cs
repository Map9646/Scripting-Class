using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {
	// Variables
	public int number;
	public float speed;
	public string name;
	public string dialoge;
	public float percentage;
	public int year;
	public string town;

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
		dialoge ="Hello, my name is Bob";
		percentage = 0.52f;
		year = 2019;
		town = "juneau";
		
		/*
		New
		Multiline text 
		for practice
		Practice 
		makes
		perfect! */;

		
	}
		
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(number,0,0);
			
	}
}
