using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    GameObject mainCircle;
    GameObject spinningCircle;
    public Animator animator;
    void Start()
    {
        mainCircle = GameObject.FindGameObjectWithTag("maincircletag");
        spinningCircle = GameObject.FindGameObjectWithTag("spinningcircletag");
        
    }
    public void gameOver()
    {
        spinningCircle.GetComponent<Spinning>().enabled = false;
        mainCircle.GetComponent<mainCircle>().enabled = false;
        animator.SetTrigger("theFinish");
    }

 
}
