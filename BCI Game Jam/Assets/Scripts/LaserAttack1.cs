using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAttack1 : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered");
        if (collision.tag == "asteroid")
        {
            Debug.Log("Attempting Explosion");
            collision.gameObject.GetComponent<Planet>().DieAsteroid();
        }
    }
}
