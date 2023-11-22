using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButton : MonoBehaviour
{
    public Transform parent;
    public GameObject slash;

    public void playerAttack()
    {  
        Instantiate(slash, parent.transform.position, parent.transform.rotation);
    }

}
