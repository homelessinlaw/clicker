using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Damager : MonoBehaviour, IPointerDownHandler
{
   public float damage = 90;
    public new Renderer  renderer;

    void Start()
    {
      
    }
    void Update()
    {
        if(this.GetComponent<HealthForCubes>().getHP() <= (this.GetComponent<Enemy>().getMaxHP()*0.5f))
        {
           
            renderer.material.SetColor("_Color",Color.red);
        }
    }
    public void OnPointerDown (PointerEventData eventData)
    {
        this.GetComponent<Enemy>().health.setDMG(damage);

    }
}
