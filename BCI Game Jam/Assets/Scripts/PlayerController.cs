using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D player;
    public float Health;
    public float upDownSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        player.velocity = new Vector2(player.velocity.x, Input.GetAxis("Vertical") * upDownSpeed );
    }
}
