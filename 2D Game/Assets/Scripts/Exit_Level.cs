using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_Level : MonoBehaviour{

public int levelToLoad;
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            
        SceneManager.LoadScene(levelToLoad);
        }
    }
    public void LevelExit(){
        Application.Quit();   
    }
}

    