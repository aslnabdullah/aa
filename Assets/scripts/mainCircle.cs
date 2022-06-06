using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCircle : MonoBehaviour
{
    public GameObject smallCircle;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            makeSmallCircle();

        }
        
    }
    void makeSmallCircle()
    {
        Instantiate(smallCircle, transform.position, transform.rotation);

    }
}
