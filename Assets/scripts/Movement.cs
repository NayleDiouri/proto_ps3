using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Joystick joystick;
    public Rigidbody2D rb;
    public GameObject attackButton;
    public float speed;
    public float spawnTime = 3f;
    private Vector3 spawnPosition;
    private GameObject Player;
    public GameObject enemy;
    public GameObject popUps;
    public int maxHealth = 100, currentHealth;
    public HealthBar healthBar;
    private bool invincibility = false;
    private string direction;


    void Start()
    {
        popUps.SetActive(false);
        Player = GameObject.Find("Player");
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 Input = new Vector2(joystick.Horizontal, joystick.Vertical);
        rb.MovePosition((Vector2)transform.position + Input * speed * Time.deltaTime);
        direction = joystick.Direction.ToString();
        print(direction);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ennemy" && invincibility == false)
        {
            TakeDamage(20);
            invincibility = true;
            Invoke("InvincibilityDuration", 1f);
        }
    }

    void Spawn()
    {
        spawnPosition = Random.insideUnitCircle.normalized * 6;


        Instantiate(enemy, Player.transform.position + spawnPosition, Quaternion.identity);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth); 
    }
    void InvincibilityDuration()
    {
        invincibility = false;
    }

}