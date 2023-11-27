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

    void Start()
    {
        Player = GameObject.Find("Player");
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 Input = new Vector2(joystick.Horizontal, joystick.Vertical);
        rb.MovePosition((Vector2)transform.position + Input * speed * Time.deltaTime);
    }

    void Spawn()
    {
        spawnPosition.x = Random.Range(Player.transform.position.x - 2, Player.transform.position.x + 2);
        spawnPosition.y = Random.Range(Player.transform.position.y - 5, Player.transform.position.y + 5);

        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }

}