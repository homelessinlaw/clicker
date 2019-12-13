using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BossEnemy :  Enemy
{
   

    // Start is called before the first frame update
    void Start()
    {
        health.setHP(300);
        move = new LinearMove();
        damage = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public new float getMaxHP()
    {
        return 300;
    }

}
