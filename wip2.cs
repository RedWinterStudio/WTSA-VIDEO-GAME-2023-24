using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class wip2 : MonoBehaviour
{
    public PlayableDirector Mr_bombastic;
    // Start is called before the first frame update
    void Start(){

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bye(){
        Invoke("loads", 0.87f);
        Mr_bombastic.Play();
    }
    private void loads(){
        SceneManager.LoadScene("Title");
    }
}
