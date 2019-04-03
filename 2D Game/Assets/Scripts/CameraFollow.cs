using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour{

    public CharacterControl player;

    public bool isFollowing;

    public float xOffset; //For the position of the Camera
    public float yOffset;



    // Start is called before the first frame update
    void Start(){

        player = FindObjectOfType<CharacterControl>();
        isFollowing = true;


        
    }

    // Update is called once per frame
    void Update(){
        
        if(isFollowing){
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z);

        }
    }
}
