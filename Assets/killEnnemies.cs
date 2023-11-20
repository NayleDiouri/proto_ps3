using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killEnnemies : MonoBehaviour
{
    public GameObject ennemy;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ennemy")
        {
            Destroy(ennemy);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
