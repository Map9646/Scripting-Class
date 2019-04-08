using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour{
    
    //Also known as a Hashtable and uses Key value pair

    public Hashtable myCharacters = new Hashtable();
    public Hashtable otherCharacters = new Hashtable();



    // Start is called before the first frame update
    void Start(){

        myCharacters.Add("firstName", "Katyln");
        myCharacters.Add("lastName", "Caldwell");
        myCharacters.Add("gender", "female");
        myCharacters.Add("race", "half-ling");
        myCharacters.Add("isMarried", "false");
        myCharacters.Add("isRoyal", "false");
        myCharacters.Add("age", 14);

        print((string)myCharacters["Katlyn"]); //To print is slightly differnt, but form is generally the same:)

        myCharacters.Add("firstName","Kahlavar");
        myCharacters.Add("lastName", "Natashka");
        myCharacters.Add("gender", "male");
        myCharacters.Add("race", "kahaizan");
        myCharacters.Add("isMarried", "false");
        myCharacters.Add("isRoyal", "true");
        myCharacters.Add("age", 20);

        print((string)myCharacters["Prince Kahlavar"]);


        otherCharacters.Add("firstname", "Milo");
        otherCharacters.Add("lastName", "Salazar");
        otherCharacters.Add("gender", "male");
        otherCharacters.Add("race", "human-wizard");
        otherCharacters.Add("isMarried", "false");
        otherCharacters.Add("isRoyal", "false");
        otherCharacters.Add("age", 15);

        print((string)otherCharacters["Milo Salazar"]);

        otherCharacters.Add("firstName", "Jessica");
        otherCharacters.Add("lastName", "Caldwell");
        otherCharacters.Add("gender", "female");
        otherCharacters.Add("race", "human-witch");
        otherCharacters.Add("isMarried", "false");
        otherCharacters.Add("isRoyal", "false");
        otherCharacters.Add("age", 14);

        print((string)otherCharacters["Jessica"]);

        otherCharacters.Add("firstName", "Suko");
        otherCharacters.Add("lastName", "Natashka");
        otherCharacters.Add("gender", "male");
        otherCharacters.Add("race", "kahaizan");
        otherCharacters.Add("isMarried", "true");
        otherCharacters.Add("isRoyal", "true");
        otherCharacters.Add("age", 125);

        print((string)otherCharacters["Pharoka Suko"]);


        //For HW do 5 of these and get caught up on all the scripts I have missed
        
    }
}
