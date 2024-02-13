using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Saw : MonoBehaviour{
    private Vector3 rotor = new Vector3(0, 0, 5);
    void Start(){
        Invoke("doink", 0);
    }
    private void doink(){
        transform.localEulerAngles = rotor;
        Invoke("skonk", 0);
    }
    private void skonk(){
        Invoke("doink", 0.1f);
    }






}