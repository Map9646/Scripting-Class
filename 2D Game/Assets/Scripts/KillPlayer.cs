using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour{

    public Level_Manager levelManager;

    // Start is called before the first frame update
    void Start(){

        levelManager = FindObjectOfType<Level_Manager>();
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.name == "Player"){
            levelManager.RespawnPlayer();
        }
    }



    // Update is called once per frame
    void Update(){

        
    }
}
