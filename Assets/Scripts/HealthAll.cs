using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthAll : MonoBehaviour
{
    

    protected float health;
    protected GameObject manager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("SpawnManager");
    }

    private void Update()
    {
        if(health <= 0)
        {
            manager.GetComponent<SpawnManager>().increaseScore();
            Destroy(this.gameObject);
        }
    }

   public void setDMG(float damage)
    {
        health -= damage;
    }
   public float getHP()
    {
        return health;
    }
    public void setHP(float HP)
    {
        health = HP;
    }

   
}
