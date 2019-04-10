using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour{
    public float Speed;
    public float timeOut;
    public GameObject Player;
    public GameObject enemyDeath;
    public GameObject projectileParticle; //For if it hits something other than the enemy, such as a wall
    public int pointsForKill; 


    // Start is called before the first frame update
    void Start(){
        Player = GameObject.Find("Player");

        enemyDeath = Resources.Load("Prefabs/PS") as GameObject;

        projectileParticle = Resources.Load("Prefabs/PS") as GameObject;

        if(Player.transform.localScale.x < 0){ //Ensures that projectile shoots the same direction as the player in facing 
            Speed = -Speed;
            //if you have only one single line after an if statement you don't have to add bracets, but you can if you want for practice
        }
            
        Destroy(gameObject, timeOut); // Will destry the projectile object after a certain amount of time
    }

    // Update is called once per frame
    void Update(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);

    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Enemy"){
            Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManager.AddPoints(pointsForKill);
        }

        Destroy(gameObject); //Destroys projectile after hitting enemy. Otherwise it would just keep going after it hit the enemy

    }

    void OnCollisionEnter2D(Collision2D other){
        Instantiate(projectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }


    





}
