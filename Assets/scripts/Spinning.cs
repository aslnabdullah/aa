﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{


    public float velocity;
    void Update()
    {
        transform.Rotate(0, 0, velocity * Time.deltaTime);
        
    }
}
