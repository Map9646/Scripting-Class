using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour{
    
    //Also known as a Hashtable and uses Key value pair

    public Hashtable myCharacters = new Hashtable();



    // Start is called before the first frame update
    void Start(){

        myCharacters.Add("firstName", "Katyln");
        myCharacters.Add("lastName", "Caldwell");
        myCharacters.Add("gender", "female");
        myCharacters.Add("isMarried", "false");
        myCharacters.Add("isRoyal", "false");
        myCharacters.Add("age", 14);

        print((string)myCharacters["Katlyn"]); //To print is slightly differnt, but form is generally the same:)

        //For HW do 5 of these and get caught up on all the scripts I have missed
        
    }
}
