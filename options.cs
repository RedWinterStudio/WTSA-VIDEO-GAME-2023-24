using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class options : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnOptionsButtonClick(){
        Invoke("LOADER", 0.5f);
    }
    private void LOADER(){
        SceneManager.LoadScene("Options");
    }
}
