using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public Level_Manager level_Manager;
//Look up Script

    // Start is called before the first frame update
    void Start()
    {
        level_Manager = FindObjectOfType<Level_Manager>();
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.name == "Player"){
            level_Manager.RespawnPlayer();
        }
    }
}
