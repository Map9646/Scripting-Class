﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_Level : MonoBehaviour{
    //Index: level to load
    public int levelToLoad;

    //This function loads the level stored in the levelToLoad variable
    public void LoadLevel(){
        SceneManager.LoadScene(levelToLoad);
    }

    //This function quits the game after the button is pressed
    public void LevelExit(){
        Application.Quit();
 
}
   

} 


   
    