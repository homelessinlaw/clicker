using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuotHeal : MonoBehaviour
{
   
    public float towerHP;
    // Start is called before the first frame update
    void Start()
    {  //почему 0????
        //towerHP = this.gameObject.GetComponentInParent<HealthforTower>().getHP();
    }

    // Update is called once per frame
    void Update()
    {
        towerHP = this.gameObject.GetComponentInParent<HealthforTower>().getHP();
        if(towerHP < 100)
        {
            this.gameObject.GetComponentInParent<HealthforTower>().setHP(towerHP + 0.005f);
        }

    }
}
