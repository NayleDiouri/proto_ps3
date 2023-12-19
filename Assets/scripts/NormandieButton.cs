using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormandieButton : MonoBehaviour
{
    public GameObject bretagne, normandie;
    public void LaunchNormandie()
    {
        bretagne.SetActive(false);
        normandie.SetActive(false);
        SceneManager.LoadScene("Normandie", LoadSceneMode.Single);
    }
}
