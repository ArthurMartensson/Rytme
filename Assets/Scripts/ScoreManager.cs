using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text text;
    public int score = 0;

    public void UpdateScore(int s)
    {
        score += s;
        text.text = "Score: " + score;
    }
}