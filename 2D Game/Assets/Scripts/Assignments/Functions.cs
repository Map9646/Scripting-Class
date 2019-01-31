using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public string weather; 
	
	void Start(){
		
		Weather(weather);
	}

	void Weather(string weatherState){
		print("the current weather is "+ weatherState );

		if(weatherState == "Sunny"){
			print("the sun is shining today!");
		}
		else if(weatherState == "Raining"){
			print("it is soggy and wet today!");
		}

		else if(weatherState == "Windy"){
			print("It is very windy today!");
		}

		else if(weatherState == "Snowing"){
		print("It is a blizzard today!");
		}
		
		else if(weatherState == "Foggy"){
			print("Bad weather due to fog.");
		}
		else{
			print("I understand"+ weatherState);
		}
	}

	
		
}
