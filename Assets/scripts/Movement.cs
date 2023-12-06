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

    void Start()
    {
        popUps.SetActive(false);
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
        spawnPosition = Random.insideUnitCircle.normalized * 6;


        Instantiate(enemy, Player.transform.position + spawnPosition, Quaternion.identity);
    }

}