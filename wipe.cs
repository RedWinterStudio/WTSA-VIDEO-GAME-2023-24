using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class wipe : MonoBehaviour
{

private bool wiping = false;
public GameObject wiper;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("ogo", 2);
        wiping = true;
        Invoke("stahp", 3);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void ogo(){
        Invoke("boi", 0.01f);
    }
    private void boi(){
        if(wiping){
            transform.position = transform.position + new Vector3(0, 1f, 0);
            Invoke("ogo", 0);
        }
    }
    private void stahp(){
        wiping = false;
        transform.position = new Vector2(-7, -35);
    }
    public void buttonwipe(){
        wiping = true;
        Invoke("ogo", 0);
    }
}
