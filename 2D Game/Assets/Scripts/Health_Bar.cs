using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Bar : MonoBehaviour{

    public int healthBar;
    public int currentHP;
    


    // Start is called before the first frame update
    void Start(){

        healthBar = 100;

        currentHP = healthBar;


        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void damageTaken(){
        currentHP -= damageTaken;

        if(currentHP <= 0){
            currentHP <= 0;
            print("Game Over!");
        }    
        
    }


         
    }
    

