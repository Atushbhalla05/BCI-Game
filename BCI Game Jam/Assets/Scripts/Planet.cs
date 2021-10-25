using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject explosion;


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    public void DieAsteroid(){
        Debug.Log("Attempting death");
        for (int i = 0; i < 16; i++)
        {
            int offset = i - 8;
            Instantiate(explosion, transform.position - new Vector3(0,offset,0), Quaternion.identity);
        }

        Destroy(this.gameObject);
    }

    public void DiePlanet()
    {
        Debug.Log("Attempting death");
        
        Instantiate(explosion, transform.position, Quaternion.identity);


        Destroy(this.gameObject);
    }


}
