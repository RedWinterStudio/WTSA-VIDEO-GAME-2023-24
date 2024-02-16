using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public int opendrrr;
    private int rand;
    private bool MURICA = false;
    //1=bottom door
    //2=top door
    //3=left door
    //4=right door
    
    private he_seeks_the_parmasean parmasean;
    void Start()
    {
        parmasean = GameObject.FindGameObjectWithTag("booms").GetComponent<he_seeks_the_parmasean>();
        Invoke("FREEEEEDOM", 0.1f);
    }
    void FREEEEEDOM(){
        Debug.Log("Fortunate son");
        if(MURICA == false){
            if(opendrrr == 1){
                //boga boga
                rand = Random.Range(0, parmasean.domcom.Length);
                Instantiate(parmasean.domcom[rand], transform.position, parmasean.domcom[rand].transform.rotation);
            }
            if(opendrrr == 2){
                //boga boga
                //boga boga
                rand = Random.Range(0, parmasean.uproms.Length);
                Instantiate(parmasean.uproms[rand], transform.position, parmasean.uproms[rand].transform.rotation);            
            }
            if(opendrrr == 3){
                //boga boga
                //boga boga
                rand = Random.Range(0, parmasean.Lroms.Length);
                Instantiate(parmasean.Lroms[rand], transform.position, parmasean.Lroms[rand].transform.rotation);            
            }
            if(opendrrr == 4){
                //boga boga
                //boga boga
                rand = Random.Range(0, parmasean.RRR.Length);
                Instantiate(parmasean.RRR[rand], transform.position, parmasean.RRR[rand].transform.rotation);            
            }
            MURICA = true;

    }
    }
    void Update(){
        Vector3 byebye = new Vector3(107, 328, transform.position.z);

        if(transform.position == byebye){
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "sPAWNPOINT"){
            if(other.GetComponent<spawn>().MURICA == true){
                Destroy(gameObject);
            }
        }
    }
    
    }
