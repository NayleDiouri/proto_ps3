using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LoreButton : MonoBehaviour
{
    public GameObject bretagne, normandie, bouton, boutonSkip;
    public Sprite lore1, lore2, tuto;
    public Image imgLore;
    
    void Start()
    {
        bretagne.SetActive(false);
        normandie.SetActive(false);
    }

    public void CloseLore()
    {
        gameObject.SetActive(false);
        bretagne.SetActive(true);
        normandie.SetActive(true);
    }

    public void SkipLore()
    {
        if(imgLore.sprite == lore1)
        {
            imgLore.sprite = lore2;
        }
        else if(imgLore.sprite == lore2)
        {
            imgLore.sprite = tuto;
            bouton.SetActive(true);
            boutonSkip.SetActive(false);
        }

    }


}
