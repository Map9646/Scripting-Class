﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour{

    public string suspect;
    
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

}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }

   

    
