using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

    public int bottles = 100;
    public bool isRaining = true;
   
    // Start is called before the first frame update
    void Start(){
        

        //For loop
        //for(int i=0; i <= bottles; i++){  //i=0 is where the loop begins each time
            //print(i +"bottles of root beer on the wall");

    // Loops work well with things like objects such as crates that need to loop and come back each time
        //}  

        //while loop
            while(bottles <= 100){
                print(bottles + "bottles of root beer on the wall");
                bottles ++;
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
