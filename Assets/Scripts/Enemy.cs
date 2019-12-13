using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Move move;
    public Damager damager;
    public HealthForCubes health;

    protected float damage;
    protected float timeForMove = 0;
    // Start is called before the first frame update
    void Start()
    {
        health = this.gameObject.GetComponent<HealthForCubes>();
        health.setHP(100);
        damage = 30;
        move = new LinearMove();
    }

    private void Update()
    {
        timeForMove += Time.deltaTime;
        if(timeForMove >= 10)
        {
            timeForMove = 0;
            swapMove();
        }
    }

    void swapMove()
    {
        move = new SinMove();
    }
    public void setDamage(float DMG)
    {
        damage = DMG;
    }
    public float getDamage()
    {
        return damage;
    }
    public float getMaxHP()
    {
        return 100;
    }
}
