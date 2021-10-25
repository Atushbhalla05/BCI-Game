using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAttack2 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered");
        if (collision.tag == "planet")
        {
            Debug.Log("Attempting Explosion");
            collision.gameObject.GetComponent<Planet>().DiePlanet();
        }
    }
}
