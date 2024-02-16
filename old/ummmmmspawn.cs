using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ummmmmspawn : MonoBehaviour
{
    public GameObject[] obs;
    void Start()
    {
        int rand = Random.Range(0, obs.Length);
        Instantiate(obs[rand], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
