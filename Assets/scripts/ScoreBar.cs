using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBar : MonoBehaviour
{
    public Slider sliderScore;
    // Start is called before the first frame update
    public void SetMinScore(int score)
    {
        sliderScore.minValue = score;
        sliderScore.value = score;
    }

    public void SetScore(int score)
    {
        sliderScore.value = score;
    }
}
