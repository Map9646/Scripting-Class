using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

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
    // Start is called before the first frame update
    void Start(){

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
