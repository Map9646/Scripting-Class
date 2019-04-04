using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager : MonoBehaviour{

public GameObject currentCheckPoint;
public Rigidbody2D pcRigid;
public GameObject Player;

public Object deathParticle; // look up what I called these two when I get to class
public GameObject respawnParticle;

public int pointPenalityOnDeath;
public float gravityStore;
public int respawnDelay;



        

    // Start is called before the first frame update
    void Start(){
        pcRigid= GameObject.Find("Player").GetComponent<Rigidbody2D>();
        Player = GameObject.Find("Player");   
        
    }
       
        
        
        public void RespawnPlayer(){
            StartCoroutine ("RespawnPlayerCo");
        }
        
        public IEnumerator RespawnPlayerCo(){ // instantiate means to represent as, so that's why it's used to call upon the particles
            Instantiate(deathParticle, pcRigid.transform.position, pcRigid.transform.rotation);

            //This line of script is to hide the player when he "dies"
            Player.SetActive(false); //hides all aspects of the player:)
            Player.GetComponent<Renderer>().enabled = false;

            gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
            pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
            pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;


            ScoreManager.AddPoints(-pointPenalityOnDeath);

            Debug.Log ("PC Respawn");

            //Next line is so the player won't respawn instantaniously 
            yield return new WaitForSeconds(respawnDelay);


            pcRigid.transform.position = currentCheckPoint.transform.position;
            pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;

            //Next line is for showing the player again when he respawns
            Player.SetActive(true);
            Player.GetComponent<Renderer>().enabled = true;

            //Respawn Particles when Player respawns into game
            Instantiate (respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
            
        }
    

    // Update is called once per frame
    void Update(){

        
    }
}
