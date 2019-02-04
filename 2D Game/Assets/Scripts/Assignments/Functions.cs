using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public string weather; 
	public string ocean;
	public string desert;
	
	void Start(){
		
		Weather(weather);
		Ocean(ocean);
		Desert(desert);
		Frozentundra(Frozentundra);

	}
	void Frozentundra(string FrozentundraState){
		print("the icyterain state is" + FrozentundraState);

		if(FrozentundraState == "cold"){
			print("The air is very brisk today! ")
		}
		else if(FrozentundraState == "blizzard"){
			print("The blizzard is too strong!");
		}
		
	}
	void Desert(string desertState){
		print("the desert state is"+ desertState);

		if(desertState == "calm"){
			print("the desert is dry and calm today");
		}
		else if(desertState == "dust clouds"){
			print("the wind is picking up in the desert")
		}
		else if(desertState == "SandStorm"){
			print("the desert is brewing up a nasty storm")
		}
	}
	void Ocean(string oceanState){
		print("the ocean current is" + oceanState);

		if(oceanState == "Little Waves"){
			print("the seas are calm today");
		}
		else if(oceanState == "Waves"){
			print("the seas are filled with white capes today");
		}
		else if(oceanState == "Rough"){
			print("A storm is upon us!");
		}
		
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
