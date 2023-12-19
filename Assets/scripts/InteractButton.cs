using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InteractButton : MonoBehaviour
{
    public bool onArtefact = false;
    public GameObject artefact;
    public GameObject panel;
    private bool oneTime = false;
    public Image img;
    public int minScore = 0, currentScore;
    public ScoreBar ScoreBar;


    void Start()
    {
        currentScore = minScore;
        ScoreBar.SetMinScore(minScore);
    }

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
            oneTime = true;
            panel.SetActive(true);
            GainScore(10);
            if(currentScore == 100)
            {
                SceneManager.LoadScene("Defeat", LoadSceneMode.Single);
            }
        }
    }

    public void GainScore(int gain)
    {
        currentScore += gain;
        ScoreBar.SetScore(currentScore);
    }

}
