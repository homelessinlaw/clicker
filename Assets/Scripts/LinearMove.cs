﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMove : Move
{
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}