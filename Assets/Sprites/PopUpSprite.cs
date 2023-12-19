using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpSprite : MonoBehaviour
{
    public InteractButton image; 
    public Sprite spr;

    private void OnDestroy()
    {
        image.img.sprite = spr;
    }
}
