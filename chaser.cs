using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class chaser : MonoBehaviour{

    public gameObject bossman;
    private int xsync;
    private int ysync;
    private int xgoes;
    private int ygoes;
    private List<int> xpos = new List<int>();
    private List<int> ypos = new List<int>();

    private void start(){

    }

    private void update(){
        
        xsync = xpos.Length - 120;
        xgoes = xpos[count];
        xpos.Remove(count);

        ysync = ypos.Length - 120;
        ygoes = ypos[count];
        ypos.Remove(count);

        transform.position = new Vector2(xgoes, ygoes);
    }

}