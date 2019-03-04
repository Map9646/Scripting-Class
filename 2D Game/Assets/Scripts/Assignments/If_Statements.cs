using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour{

    public string stopLight;
    public bool isUtahn = true;
    public string weather;
    public string lampLight;


    // Start is called before the first frame update
    void Start(){
        StopLight(stopLight);
        Weather(weather);
        LampLight(lampLight);
        
        
    }

    // Update is called once per frame
    void Update(){

        void StopLight(string stopLight){
        if(stopLight == "Red"){
            //blockof code that is run if the condition is met
            // ! means NOT
            
        if(isUtahn){
               print("Stop! The light is Red!"); 
            }
            
        }
        else if(stopLight == "Yellow"){
            print("You've got this, bruh!");

        }
        else if(stopLight == "Green"){
            
        }
        else{
             print("Check phone, turn up radio and sit at light until almost yellow, then go!");
        }
       
        }
        
        void Weather(string weather){
            if(weather == "sunny"){
                print("The sun is shining on us today!");
            }

            else if(weather == "cold"){
                print("It's chilly today.");
        
            }

            else if(weather == "raining"){
                print("It's raining cats and dogs outside!");
            }

            else if(weather == "snowing"){
                print("It's snowing today.");
            }

            else if(weather == "lightning"){
                print("There is a huge storm outside. You better get back inside where it is safe.");
            }
        }

            void LampLight(string lampLight){
                if(lampLight == "Green"){
                    print("Green is my favorite color, so pretty!");
                }
                else if(lampLight == "Red"){
                    print("I hide when it turns red cause all the shadows come out.");
                }

                else if(lampLight == "Yellow"){
                    print("It feels like it is daytime in my room. I can't sleep like this.");
                }

                else if(lampLight == "Blue"){
                    print("So relaxing!");
                }

                else if(lampLight == "white"){
                    print("Now I can sleep cause all the monsters are gone.");
                }


            }
        

        }
    
    }
}
