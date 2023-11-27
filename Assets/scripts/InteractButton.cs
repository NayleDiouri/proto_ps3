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
    public enum FoodArtefactsBretagne
    { 
        Cidre,
        Chouchen,
        Caramel,
        Crepe,
        KouignAmann,
        Moules

    }

    public enum MysticArtefactBretagne
    {
        TriquetraCeltique,
        Excalibur,
        Durandal
    }

    public enum FoodArtefactsNormandie
    {
        Andouille,
        Fromage,
        Calvados,
        Omelette,
        TartePommes,
        SaintJacques
    }

    public enum MysticArtefactsNormandie
    {
        BigorneChicheface,
        DemoiselleTonneville,
        DameBlanche
    }

}
