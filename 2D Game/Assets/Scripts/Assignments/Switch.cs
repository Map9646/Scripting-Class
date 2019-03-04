using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour{

    public string suspect;
    public string weapon;
    public string evidence;
    
    // Start is called before the first frame update
    void Start() {
        
        MurderMystery(suspect);
        
        }
        
    void MurderMystery (string person){
        switch(person){
            case "Mr. Ketchup":
            print("I was in the backyard playing with the dog with Mr. Radish.");
            break;
            
            case "Mr. Radish":
            print("I was in the backyard playing with the dog with Mr. Ketchup.");
            break;

            case "Ms. Frysauce":
            print("I was talking on the phone with my mother, Mrs. Mayo.");
            break;

            case "Mrs. Mayo":
            print("I was in the kitchen washing the dishes");
            break;

            default:
            print("I am not familiar with" +suspect+"!");
            break;

            // Went over how a switch works and cases and how they work as well. 

            }

            switch(weapon){
                case "Kitchen Knife":
                print("Kitchen Knife found in an unusal place in the kitchen");
                break;

                case "Axe":
                print("Axe was found in the backyard in an usual spot.");
                break;

                case "Gun"
                print("Small pistol found in master bedroom."

            }

            switch(evidence){

            case "Ms. FrySauce in Master Bedroom";
            print("That gun belonged to my dad. My mom, Mrs. Mayo hated it.");
            break;

            case "Mrs. Mayo"
            print("I was only doing dishes. I don't know why someone would kill my husband. Stop askig me silly questions.");
            break;

            /*Ask Preston why this segment is blue for switch and the other is purple. 
            I'm not sure what I did wrong here. It may be syntax. Have to check in unity on Monday. */
            }
            }
            
            
            

    }

            

}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }

   

    
