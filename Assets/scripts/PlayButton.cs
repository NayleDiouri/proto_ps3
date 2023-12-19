using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject lore, bouton;
    void Start()
    {
        lore.SetActive(false);
    }

    public void LaunchGame()
    {
        gameObject.SetActive(false);
        lore.SetActive(true);
        bouton.SetActive(false);
    }
}
