using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButton : MonoBehaviour
{
    public Transform parent;
    public GameObject slash;

    public Movement player;

    public void playerAttack()
    {

        Instantiate(slash, parent.transform.position, Quaternion.Euler(player.vectorDirection.x, player.vectorDirection.y, 0f));
    }

}
