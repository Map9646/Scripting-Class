using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDeathParticles : MonoBehaviour{

    private ParticleSystem thisParticleSystem;




    // Start is called before the first frame update
    void Start(){

        if(thisParticleSystem.isPlaying)
            return;

        Destroy(gameObject);        
    }

    void OnBecameInvisible(){
        Destroy (gameObject);
    }

    // Update is called once per frame
    void Update(){

        
    }
}
