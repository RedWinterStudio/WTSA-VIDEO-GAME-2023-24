using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector : MonoBehaviour
{
    public GameObject selectees;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selectees.SetActive(false);
    }
    void OnMouseOver(){
        selectees.SetActive(true);
    }
}
