using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camshaft : MonoBehaviour
{
    private Vector3 bof = new Vector3(0, 0, -10);
    private float smoh = 0.1f;
    private Vector3 velo = Vector3.zero;
    public Transform taget;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector3 Tarpos = taget.position + bof;
        transform.position = Vector3.SmoothDamp(transform.position, Tarpos, ref velo, smoh);
    }
}
