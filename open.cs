using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class open : MonoBehaviour
{
private float steps = 90.0f;
private float time = 0.25f;
private float elapse = 0.0f;
private float bs = 0.0f;
public GameObject snow;
private Vector3 start = new Vector3(0, 8, 0);
private Vector3 end = new Vector3(0, 2, 0);


    // Start is called before the first frame update
    void Start()
    {
        Invoke("byebye", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 current = transform.position;
        elapse += Time.deltaTime;
        float percentage = elapse / time;
        bs = transform.position.y;
        transform.position = Vector3.Lerp(start, end, percentage);
        if(bs == 2){

            Invoke ("sksksk", 0.25f);
            }
    }
    
    void sksksk(){
        if(steps > 0.0f){
            transform.Rotate(0, 0, 1, Space.Self);
            steps -= 1;
            Invoke ("sksksk", 0.25f);
    }

    }
    private void byebye(){
        snow.SetActive(false);
    }
}
