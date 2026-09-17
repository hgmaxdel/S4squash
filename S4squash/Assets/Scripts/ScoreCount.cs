using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    private int scoreCount = 0;
    public TMP_Text scoreText;

    public void AddScore()
    {
        scoreCount++;
        scoreText.text = "Score: " + scoreCount.ToString();
    }
}
