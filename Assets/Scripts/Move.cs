using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{ public float speed;
    public Transform towerTransform;
    private Transform boxTransform;
    private bool stopBox;
    // Start is called before the first frame update
    void Start()
    {
      
        boxTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.009f;
        Vector3 pos = new Vector3(0, Time.deltaTime * speed, 0);
        boxTransform.position += pos;
       
    }
   
}
