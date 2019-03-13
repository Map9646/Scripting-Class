using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour{

    //HW for this week: Do five examples of arrays,lists and arraylist. Make c# script for all three so it is organized.

    //Collection of client variables
    public string clinent1 = "Greg";
    public string clinent2 = "Kate";
    public string clinent3 = "Adam";
    public string clinent4 = "Mia";
    public string clinent5 = "Fred";
    
    //An Array makes things easier to list things out in one set of code
    //Array Example
    public string[] clientList = new string[]{"Greg","Kate","Adam","Mia","Fred"};
    public string[] friendsList = new string[]{"Virginia","Coy","Britny"};
    public int[] scoresList = new int[]{10,8,5,2};
    public string[] citiesList = new string[]{"Juneau","Orem","Kansas City"};
    public int[] testscoreList = new int[]{10,7,5,5,9};
    //An Array is fixed and cannot be changed, but can be used for strings, floats, and gameobjects 
    

    //List Example(Run a little slower than arrays and also scalable)
     public List<string> santasList = new List<string>();
     public List<string> myfriendList = new List<string>();
     public List<int> bankList = new List<int>();
     public List<string> girlList = new List<string>();
     public List<string> campingList = new List<string>();
    //can add and take away from lists after list is created


    //ArrayLists Example
    //can mix and match data types with arraylist unlike the other two
    public ArrayList inventory = new ArrayList();
    public ArrayList shopping = new ArrayList();


     // Start is called before the first frame update
    void Start(){
        
        //Lists
        santasList.Add("Jimmy");
        santasList.Add("Jenny");
        santasList.Add("Sam");
        santasList.Add("Ty");
        santasList.Add("Susie");
        santasList.Remove("Jimmy");
        
        print(clientList[2]);

        print(santasList[3]);


        myfriendList.Add("Coy");
        myfriendList.Add("Virginia");
        myfriendList.Add("Britny");

        bankList.Add(1000);
        bankList.Add(350);
        bankList.Remove(350);


        girlList.Add("Jessica");
        girlList.Add("Abby");
        girlList.Add("Megara");


        campingList.Add("Tent");
        campingList.Add("food");
        campingList.Add("Sleeping Bag");


        //ArrayLists

        inventory.Add(10);
        inventory.Add("Bob");
        inventory.Add(true);
        inventory.Add(5.2341);

        print(inventory[0]);

        shopping.Add("Fruit");
        shopping.Add("Vegtables");
        shopping.Add("Frysauce");
        shopping.Remove("Frysauce");
        shopping.Add("Ice Cream");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
