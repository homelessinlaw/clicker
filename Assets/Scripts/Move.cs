using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   public float speed;
    public Transform towerTransform;
    
  
    private bool stopBox;


    // Update is called once per frame
    void Update()
    {
       
        this.transform.Translate(0,Time.deltaTime * speed, 0);
       
    }
   
}
