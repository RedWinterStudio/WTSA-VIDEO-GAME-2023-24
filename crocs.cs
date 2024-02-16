using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crocs : MonoBehaviour
{
    public GameObject crocsc;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("crcos", 2.5f);        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void crcos(){
        crocsc.SetActive(false);
    }
}
