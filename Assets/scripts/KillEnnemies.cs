using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnnemies : MonoBehaviour
{
    public GameObject ennemy;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ennemy")
        {
            Destroy(collision.gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
