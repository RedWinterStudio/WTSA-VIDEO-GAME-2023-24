using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class chaser : MonoBehaviour{

    public GameObject bossman;
    public GameObject Dipshit;
    private int xsync;
    private int count;
    private int ysync;
    private float xgoes;
    private float ygoes;
    private List<float> xpos = new List<float>();
    private List<float> ypos = new List<float>();

    private void start(){
        Invoke("skoks", 2);
        Debug.Log("started");
    }

    private void skoks(){
        xpos.Add(Dipshit.transform.position.x);
        ypos.Add(Dipshit.transform.position.y);

        Debug.Log("running");

        xsync = xpos.Count - 20;
        xgoes = xpos[xsync];
        xpos.Remove(xsync);
        

        ysync = ypos.Count - 20;
        ygoes = ypos[xsync];
        ypos.Remove(xsync);

        transform.position = new Vector2(xgoes, ygoes);
        Invoke("Grog", 0);
    }
    private void Grog(){
        Invoke("skoks", 0.1f);
    }

}