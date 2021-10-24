using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LaserStateTrigger : MonoBehaviour
{
    public bool laserState;
    public GameObject LaserAttack1;
    public GameObject LaserAttack2;

    void Start()
    {
        laserState = true;
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (laserState == true)
            {
                LaserAttack2.SetActive(false);
                LaserAttack1.SetActive(true);
                laserState = false;
            }
            else
            {

                LaserAttack1.SetActive(false);
                LaserAttack2.SetActive(true);
                laserState = true;
            }
        }
    }
}