using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    public GameObject bgr;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("zoks", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void zoks(){
        bgr.SetActive(false);
    }
}
