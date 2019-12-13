using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   
   protected Rigidbody rb;
    //Vector3 velocity;
     void Start()
    {
        //rb = this.gameObject.GetComponent<Rigidbody>();
        //rb.velocity = new Vector3(0, 3, 0);
    }
    // Update is called once per frame
    void Update()
    {
       
        //this.transform.Translate(0,Time.deltaTime * speed, 0);

        
    }

    public Rigidbody getRB()
    {
        return rb;
    }
   
}
