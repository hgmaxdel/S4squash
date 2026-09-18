using UnityEngine;
using TMPro;

public class CollisionHandler : MonoBehaviour
{
    private int scoreCount = 0;
    private int bounceCount = 0;
    public TMP_Text scoreText;

    public void AddScore()
    {
        scoreCount++;
        scoreText.text = "Score: " + scoreCount.ToString();
    }

    public void AddBounceCount()
    {
        bounceCount++;

        if (bounceCount == 2)
        {
            RemoveScore();
            bounceCount = 0;
        }
    }

    public void RemoveScore()
    {
        scoreCount = 0;
        scoreText.text = "Score: " + scoreCount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScoreHitBox"))
        {
            AddScore();
            bounceCount = 0;
            Debug.Log("Hit");
            Debug.Log(scoreCount);
        }

        else if (other.gameObject.CompareTag("OutOfBounds"))
        {
            RemoveScore();
            bounceCount = 0;
            Debug.Log("u suck lol");
        }

        else if (other.gameObject.CompareTag("FloorBounce"))
        {
            AddBounceCount();
        }
    }
}
