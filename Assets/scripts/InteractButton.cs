using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractButton : MonoBehaviour
{
    public bool onArtefact = false;
    public GameObject artefact;
    private bool oneTime = false;



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

    private void Update()
    {
        if (oneTime == true)
        {
            Debug.Log("azy y'a juste un ptiiiit probleme");
            gameObject.SetActive(true);
            oneTime = false; 
        }
    }
    public void getArtefact()
    {
        if(onArtefact == true)
        {
            Destroy(artefact);
            oneTime = true;
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

    public enum CultureArtefactsBretagne
    {
        ArmureChevalierBertrand,
        CireBreton,
        StatueMichelArchange
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

    public enum CultureArtefactsNormandie
    {
        BougieTrudon,
        StatueMichelArchange
    }

}
