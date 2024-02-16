using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Saw : MonoBehaviour{
    private Vector3 rotor = new Vector3(0, 0, 5);

    void Update(){
        transform.localEulerAngles += rotor;        
    }







}