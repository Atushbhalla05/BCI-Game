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
        Instantiate(explosion,this.transform);
        Destroy(this);
    }


}
