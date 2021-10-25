using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject explosion;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("planet got hit");
        if(collision.gameObject.tag == "Laser"){
            Die();
        }
    }

    public void Die(){
        Debug.Log("Attempting death");
        for (int i = 0; i < 16; i++)
        {
            int offset = i - 8;
            Instantiate(explosion, transform.position - new Vector3(0,offset,0), Quaternion.identity);
        }

        Destroy(this.gameObject);
    }


}
