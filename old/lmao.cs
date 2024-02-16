using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lmao : MonoBehaviour
{
    public GameObject lmaoo;
    public GameObject start;
    public GameObject options;
    public GameObject tier;
    // Start is called before the first frame update
    void Start()
    {
        lmaoo.SetActive(false);
        options.SetActive(false);
        start.SetActive(false);
        tier.SetActive(false);
        Invoke("zoks", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void zoks(){
        lmaoo.SetActive(true);
        options.SetActive(true);
        start.SetActive(true);
        tier.SetActive(true);
    }
}
