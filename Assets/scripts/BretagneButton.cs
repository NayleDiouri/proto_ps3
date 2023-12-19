using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BretagneButton : MonoBehaviour
{
    public GameObject bretagne, normandie;
    public void LaunchBretagne()
    {
        bretagne.SetActive(false);
        normandie.SetActive(false);
        SceneManager.LoadScene("Bretagne", LoadSceneMode.Single);
    }
}
