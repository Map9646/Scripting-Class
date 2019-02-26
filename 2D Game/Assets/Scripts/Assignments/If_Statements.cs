using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour{

    public string stopLight;
    public bool isUtahn = true;


    // Start is called before the first frame update
    void Start(){
        
        
    }

    // Update is called once per frame
    void Update(){
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
}
