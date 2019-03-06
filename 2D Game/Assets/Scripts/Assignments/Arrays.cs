using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour{

    //HW for this week: Do five examples of arrays, examples and arraylist. Make c# script for all three so it is organized.

    //Collection of client variables
    public string clinent1 = "Greg";
    public string clinent2 = "Kate";
    public string clinent3 = "Adam";
    public string clinent4 = "Mia";
    public string clinent5 = "Fred";
    
    //An Array makes things easier to list things out in one set of code
    //Array Example
    public string[] clientList = new string[5]{"Greg", "Kate", "Adam", "Mia", "Fred"};
    //An Array is fixed and cannot be changed, but can be used for strings, floats, and gameobjects
    

    //List Example(Run a little slower than arrays)
     public List<string> santasList = new List<string>();
    //can add and take away from lists after list is created


    //ArrayLists Example
    //can mix and match data types with arraylist unlike the other two
    public ArrayList inventory = new ArrayList();


     // Start is called before the first frame update
    void Start(){
        santasList.Add("Jimmy");
        santasList.Add("Jenny");
        santasList.Add("Sam");
        santasList.Add("Ty");
        santasList.Add("Susie");
        santasList.Remove("Jimmy");

        print(clientList[2]);

        print(santasList[3]);

        inventory.Add(10);
        inventory.Add("Bob");
        inventory.Add(true);
        inventory.Add(5.2341);

        print(inventory[0]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
