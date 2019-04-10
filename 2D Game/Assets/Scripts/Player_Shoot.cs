using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour{
    public Transform firePoint;
    public GameObject projectile; //once you figure out what you want player to throw, replace projectile with that

    //Remember to rename projectile once I know exactly what it will be. 



    // Start is called before the first frame update
    void Start(){

        projectile = Resources.Load("Prefabs/Projectile") as GameObject;
        //Error will show in Unity only because we have nothing in prefabs by that name yet
        

    }

    // Update is called once per frame
    void Update(){

        if(Input.GetKeyDown(KeyCode.E))
            Instantiate(projectile,firePoint.position,firePoint.rotation);
            //The object we create in Unity will be linked or inherited through the Player, so they have to be on the same field

        
    }
}
