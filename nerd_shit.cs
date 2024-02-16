using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nerd_shit : MonoBehaviour
{
    public Transform[] Spawnbois;
    public GameObject[] durrr;
    private int a_variable;
    private int WTF_IS_WRONG_WITH_THIS_STUPIUD_THING_STOP_GOING_DIAGONAL_PLEASE_DEAR_GOD = 10;
    //i still dont know why it was going diagonal, but i re-wrote everything and it seems to work now???
    private int stupid_variable;
    public GameObject dipshit;
    private float bogo;
    public bool STAHP = false;
    private int Rad_variable;
    public GameObject Smartass;
    private Vector3 Smartoffset = new Vector3(-3, 0, 0);
    public GameObject Bossman;
    private Vector3 Bossoffset = new Vector3(3, 0, 0);
    public float bazooka = 74345645967f;
    public float MAXXXX = 45;
    public float Minimal_shimmy = 15;
    public float YJustwhy = 65;
    public LayerMask loser_lasyermask;
    public GameObject atsrat;
    public GameObject qqq;
    void Start()
    {
        int skunks_r_cool = Random.Range(0, Spawnbois.Length);
        transform.position = Spawnbois[skunks_r_cool].position;
        Instantiate(atsrat, transform.position, Quaternion.identity);


        Smartass.transform.position = transform.position + Smartoffset;
        Bossman.transform.position = transform.position + Bossoffset;

        //Instantiate(dipshit, transform.position, Quaternion.identity);
        a_variable = Random.Range(1, 6);

    }
    void Update(){
        if(bogo <= 0 && STAHP == false){
            garfield_kart();
            bogo = bazooka;
        }
        else{
            bogo -= Time.deltaTime;
        }
    }
    private void garfield_kart(){
        if(a_variable == 1 || a_variable == 2){
            if (transform.position.x < 45){
                Rad_variable = 0;
                Vector2 newboi = new Vector2(transform.position.x + WTF_IS_WRONG_WITH_THIS_STUPIUD_THING_STOP_GOING_DIAGONAL_PLEASE_DEAR_GOD, transform.position.y);
                transform.position = newboi;
                a_variable = Random.Range(1, 6);

                stupid_variable = Random.Range(0, 4);
                Instantiate(durrr[stupid_variable], transform.position, Quaternion.identity);
                if(a_variable == 3){
                    a_variable = 1;
                    Debug.Log("3");
                }
                if(a_variable == 4){
                    a_variable = 5;
                    Debug.Log("4");
                }
            }
            else{
                a_variable = 5;
                Debug.Log("X-maxxed out");
            }
        }
        
    
        if(a_variable == 3 || a_variable == 4){
            Rad_variable = 0;
            if(transform.position.x > 15){
                Vector2 newboi = new Vector2(transform.position.x - WTF_IS_WRONG_WITH_THIS_STUPIUD_THING_STOP_GOING_DIAGONAL_PLEASE_DEAR_GOD, transform.position.y);
                transform.position = newboi;
                a_variable = Random.Range(3, 6);

                stupid_variable = Random.Range(0, 4);
                Instantiate(durrr[stupid_variable], transform.position, Quaternion.identity);
            }
            else{
                a_variable = 5;
                Debug.Log("X-minimized");
            }
            
        }
        if(a_variable == 5){
            Rad_variable++;
            if(transform.position.y > 35){

                Collider2D Dumb_Collider = Physics2D.OverlapCircle(transform.position, 1, loser_lasyermask);
                if(Dumb_Collider.GetComponent<stupid_man>().Moronic_variable != 1 && Dumb_Collider.GetComponent<stupid_man>().Moronic_variable != 3){
                    if(Rad_variable >= 2){
                        Debug.Log("Dfs");
                        Dumb_Collider.GetComponent<stupid_man>().Idiotic_void();
                        Instantiate(durrr[3], transform.position, Quaternion.identity);
                    }
                    else{
                        Dumb_Collider.GetComponent<stupid_man>().Idiotic_void();
                        int park_rando = Random.Range(1, 4);
                        if(park_rando == 2){
                            park_rando = 1;
                        }
                        Instantiate(durrr[park_rando], transform.position, Quaternion.identity);    
                    }

                }

                else{
                    Vector2 newboi = new Vector2(transform.position.x, transform.position.y - WTF_IS_WRONG_WITH_THIS_STUPIUD_THING_STOP_GOING_DIAGONAL_PLEASE_DEAR_GOD);
                    transform.position = newboi;
                    a_variable = Random.Range(1, 6);
                    

                    stupid_variable = Random.Range(2, 4);
                    Instantiate(durrr[stupid_variable], transform.position, Quaternion.identity);                    
                }

            }
            else{
                transform.position = new Vector2(transform.position.x + 10, transform.position.y);
                Instantiate(qqq, transform.position, Quaternion.identity);
                STAHP = true;

                Debug.Log("STOPPERFD");
            }
        }


    
    }
}
