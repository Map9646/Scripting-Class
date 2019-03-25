using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Patrol : MonoBehaviour{

public bool notAtEdge;
public Transform edgeCheck;

public Transform wallCheck;
public float wallCheckRadius;
public LayerMask whatIsWall;
private bool hittingWall;

public float moveSpeed;
public bool moveRight;
public Vector3 scale;


    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale;
        
    }

    // Update is called once per frame
    void Update(){
        notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);

        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

        if(hittingWall || !notAtEdge){
            moveRight = !moveRight;

        }
         if(moveRight){
             transform.localScale = new Vector3(-scale.x,scale.y,scale.z);
             GetComponent<Rigidbody2D>(). velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y); //moving right
            }

         else {
            transform.localScale = new Vector3(scale.x,scale.y,scale.z);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y); //moving left
             
            }
                
    }
}
