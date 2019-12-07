using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthforTower : MonoBehaviour
{
    public float health;
 
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {

            if (this.gameObject.name == "Tower")
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene("Menu");
            }
            Destroy(this.gameObject);
        }
    }
}
