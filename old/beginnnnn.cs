using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beginnnnn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnStartButtonClick(){
        Invoke("LOADER", 0.5f);
    }
    private void LOADER(){
        SceneManager.LoadScene("Realspace-Entry_Dungeon");
    }
}
