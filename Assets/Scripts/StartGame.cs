using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SwitchScene(string Myscene2)
    {
        //Application.LoadLevel(Myscene2);
        SceneManager.LoadScene(Myscene2);
    }
}
