using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageforTower : MonoBehaviour
{
    HealthforTower towerHealth;
    float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Tower")
        {
            Destroy(this.gameObject);
            towerHealth = GameObject.Find(collision.gameObject.name).GetComponent<HealthforTower>();
            towerHealth.setDMG(this.gameObject.GetComponent<Enemy>().getDamage());
        }
    }
}
