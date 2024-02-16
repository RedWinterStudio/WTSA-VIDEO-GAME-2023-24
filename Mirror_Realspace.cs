using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;



public class Mirror_Realspace : MonoBehaviour{

public PlayableDirector timeline;
    void Start(){

    }
    void Update(){

    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "playuer"){
            timeline.Play();
            Invoke("loader", 6.48f);
        }
    }
    private void loader(){
            SceneManager.LoadScene("Subspace2");        
    }






}