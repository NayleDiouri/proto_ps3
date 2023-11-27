using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton : MonoBehaviour
{
    public bool onArtefact = false;
    public GameObject artefact;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "artefact")
        {
            onArtefact = true;
        }
        if (onArtefact == true && collision.gameObject.tag == "artefact")
        {
            artefact = collision.gameObject;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "artefact")
        {
            onArtefact = false;
        }
    }
    public void getArtefact()
    {
        if(onArtefact == true)
        {

            Destroy(artefact);
        }
    }
}
