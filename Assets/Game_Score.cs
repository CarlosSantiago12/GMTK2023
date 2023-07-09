using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Score : MonoBehaviour
{
    public Text scoreText; // Reference to the score text UI element
    private float score; // The current score

    private void Start()
    {
        score = 0f; // Initialize the score to 0
        UpdateScoreText(); // Update the score text on start
    }

    public void IncreaseScore(float amount)
    {
        score += amount; // Increase the score by the specified amount
        UpdateScoreText(); // Update the score text
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString(); // Update the score text UI element
    }
}
