using UnityEngine;
using TMPro;

public class CollisionHandler : MonoBehaviour
{
    private int scoreCount = 0;
    public TMP_Text scoreText;

    public void AddScore()
    {
        scoreCount++;
        scoreText.text = "Score: " + scoreCount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScoreHtBox"))
        {
            AddScore();
            Debug.Log("Hit");
            Debug.Log(scoreCount);
        }
    }
}
