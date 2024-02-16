using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoonman : MonoBehaviour
{
    public LayerMask cool_lasyermask;
    private int skoko;
    public GameObject[] Awesome_gameobject;
    public nerd_shit nerd_shit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D Dope_Collider = Physics2D.OverlapCircle(transform.position, 1, cool_lasyermask);
        if(Dope_Collider == null && nerd_shit.STAHP == true){
            skoko = Random.Range(1, 4);
            Instantiate(nerd_shit.durrr[skoko], transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if(Dope_Collider != null && nerd_shit.STAHP == true){
            Destroy(gameObject);
        }   
    }


}
