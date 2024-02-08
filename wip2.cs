using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wip2 : MonoBehaviour
{
    private bool wiping;
    // Start is called before the first frame update
    void Start()
    {
        wiping = true;
        Invoke("Wipe1", 0);
        Invoke("ender", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Wipe1(){
        if(wiping){
            transform.position += new Vector3(0, 1, 0);
            Invoke("Wipe2", 0.01f);
        }
    }
    private void Wipe2(){
        Invoke("Wipe1", 0);
    }
    private void ender(){
        wiping = false;
        transform.position = new Vector2(-7, -31);
    }
    public void returny(){
        wiping = true;
        Invoke("Wipe1", 0);
        Invoke("Bye", 0.5f);
    }
    private void Bye(){
        SceneManager.LoadScene("Title");
    }
}
