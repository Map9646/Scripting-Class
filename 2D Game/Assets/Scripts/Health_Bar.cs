using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour{

    public int healthBar;
    public int currentHP;
    
    Text Health;


    // Start is called before the first frame update
    void Start(){

        healthBar = 100;

        currentHP = healthBar;

        Health = GetComponent<Text>();

        Health.text = " " + currentHP;

      


        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void damageTaken(int damage){
        currentHP -= damage;

        if(currentHP <= 0){
            currentHP = 0;
            print("Game Over!");
        }    
        
    }


         
    }
    

