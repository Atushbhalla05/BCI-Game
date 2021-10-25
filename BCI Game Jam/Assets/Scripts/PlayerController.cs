using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update


    public Rigidbody2D player;
    public int maxHealth;
    public int currentHealth;
    public float minBound;
    float pushBack;
    float maxBound;
    public float upDownSpeed;

    public HealthBar healthBar;
    void Start()
    {
        maxBound = -1*(minBound + 2.5f);
        pushBack = .05f;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0){
            SceneManager.LoadSceneAsync(2);
        }
    }

    void FixedUpdate(){
        if (player.position.y < maxBound && player.position.y > minBound)
        {
            player.velocity = new Vector2(player.velocity.x, Input.GetAxis("Vertical") * upDownSpeed);
        }
        else 
        {
            player.velocity = new Vector2(player.velocity.x, 0);

            if (player.position.y >= maxBound)
            {
                player.position = new Vector2(player.position.x, (maxBound - pushBack));
            }

            if (player.position.y <= minBound)
            {
                player.position = new Vector2(player.position.x, (minBound + pushBack));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "asteroid" || collision.gameObject.tag == "planet")
        {
            TakeDamage();
        }
    }

    public void TakeDamage(){
        currentHealth -= 1;
        healthBar.SetHealth(currentHealth);
    }
}
