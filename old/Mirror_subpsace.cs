using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Mirror_subspace : MonoBehaviour{
    
public PlayableDirector timeline;
    void Start(){
        timeline = GetComponent<PlayableDirector>();
    }
    void Update(){

    }
    private void OnCollisionEnter2D(Collider collider){
        if(collidion.gameObject.tag == "playuer"){
            timeline.Play();
            SceneManager.LoadScene("Realspace");
        }
    }






}