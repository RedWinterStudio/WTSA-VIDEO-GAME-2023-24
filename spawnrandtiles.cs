using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnrandtiles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] tile;
    private int robo_int;
    private int doesspawns;
    void Start()
    {
      Invoke("brogo_stick", 1);
    }

    // Update is called once per frame
    void brogo_stick()
    {
        robo_int = Random.Range(0, tile.Length);
        doesspawns = Random.Range(0, 2);
        if(doesspawns == 0){
            Instantiate(tile[robo_int], transform.position, Quaternion.identity);
        }  

    }
}
