using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camshaft : MonoBehaviour
{
    public GameObject Dipshit;
    public GameObject Smartass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Smartass.transform.position = new Vector3(Dipshit.transform.position.x, 0.84f, -1);
    }
}
