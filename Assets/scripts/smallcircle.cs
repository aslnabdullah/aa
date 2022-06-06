using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallcircle : MonoBehaviour
{
    Rigidbody2D pyhsics;
    public float velocity;
    bool movecontrol = false;
    GameObject gameManager;
    void Start()
    {
        pyhsics = GetComponent<Rigidbody2D>();
        gameManager = GameObject.FindGameObjectWithTag("gamemanagertag");
        
    }

    
    void FixedUpdate()
    {
        if (!movecontrol)
        {
            pyhsics.MovePosition(pyhsics.position + Vector2.up * velocity * Time.deltaTime);

        }
        

        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "spinningcircletag")
        {
            transform.SetParent(col.transform);
            movecontrol = true;

        }
        if (col.tag == "smallcircletag")
        {
            gameManager.GetComponent<gameManager>().gameOver();

        }
        
    }
}
