using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthforTower : HealthAll
{
    
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
                Destroy(this.gameObject);
                SceneManager.LoadScene("Menu");           
        }
    }
}
