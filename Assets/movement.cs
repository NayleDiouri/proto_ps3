using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Joystick joystick;
    public Rigidbody2D rb;
    public GameObject attackButton; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 Input = new Vector2(joystick.Horizontal, joystick.Vertical);
        rb.MovePosition((Vector2)transform.position + Input * 10 * Time.deltaTime);
    }

}
