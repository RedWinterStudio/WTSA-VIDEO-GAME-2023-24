using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class the_go_man : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject suckyman;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 1.54){
            Debug.Log("GREGER");
        }
    }
    private void ogo(){
        Invoke("boi", 0.02f);
    }
    private void boi(){
        if(suckyman.transform.position.y > -0.3f){
            suckyman.transform.position = transform.position + new Vector3(0, -1f, 0);
            Invoke("ogo", 0);
        }
    } 
    public void turboman(){
        Invoke("ogo", 0);
        Invoke("Later_Bitch", 0.5f);
    }
    private void Later_Bitch(){
        SceneManager.LoadScene("Title");
    }   
}
