using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shred : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(collision.gameObject);
        Debug.Log("shredder got hit");
    }
}
