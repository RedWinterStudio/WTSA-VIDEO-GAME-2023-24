using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funkyfungus : MonoBehaviour
{
    public GameObject bossman;
    public GameObject Dipshit;
    private int xsync;
    private int count;
    private int ysync;
    private float xgoes;
    private float ygoes;
    public List<float> xpos = new List<float>();
    public List<float> ypos = new List<float>();
    private int special = 200;

    private void Start(){
        Debug.Log("FUCKING WORK YOU BITCH");
        Invoke("skoks", 2);
        Debug.Log("started");
        while(special > 0){
            xpos.Add(bossman.transform.position.x);
            ypos.Add(bossman.transform.position.y);
            special -= 1;            
        }
    }
    private void Update(){
    
    }

    private void skoks(){
        xpos.Add(Dipshit.transform.position.x);
        ypos.Add(Dipshit.transform.position.y);




        xsync = xpos.Count - 120;
        xgoes = xpos[xsync];
        xpos.RemoveAt(xsync);
        

        ysync = ypos.Count - 120;
        ygoes = ypos[xsync];
        ypos.RemoveAt(xsync);

        transform.position = new Vector2(xgoes, ygoes);
        Invoke("Grog", 0);
    }
    private void Grog(){
        Invoke("skoks", 0.01f);
    }


}
