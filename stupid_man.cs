using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stupid_man : MonoBehaviour
{
    // Start is called before the first frame update
    public int Moronic_variable;
    public GameObject theobject;
    public void Idiotic_void(){
        Destroy(gameObject);
    }
    void Start()
    {
        Invoke("oh", 4);
    }

    // Update is called once per frame
    private void oh(){
        theobject.GetComponent<BoxCollider2D>().enabled = false;
}
}
