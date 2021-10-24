using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D player;
    public int maxHealth;
    public int currentHealth;
    public float upDownSpeed;

    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        player.velocity = new Vector2(player.velocity.x, Input.GetAxis("Vertical") * upDownSpeed );
    }

    void OnCollisionEnter2D(Collision2D collision){
        Destroy(collision.gameObject);
        TakeDamage();
    }

    public void TakeDamage(){
        currentHealth -= 1;
        healthBar.SetHealth(currentHealth);
    }
}
