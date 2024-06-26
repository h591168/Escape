using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private int score; // Current score
    [SerializeField] private int finalScore; // Score needed to win
    [SerializeField] private UnityEvent winAction; // Actions to perform when the final score is reached
    [SerializeField] private UnityEvent onScoreChange; // Actions to perform when the score changes

    // Method to update the score
    public void UpdateScore()
    {
        score++; // Increment the score by 1
        onScoreChange.Invoke(); // Invoke the score change event
        if (score >= finalScore) // Check if the score has reached or exceeded the final score
        {
            winAction.Invoke(); // Invoke the win action event
        }
    }

    // Method to reset the score
    public void ResetScore()
    {
        score = 0; // Reset the score to 0
        onScoreChange.Invoke(); // Invoke the score change event
    }

    // Method to get the current score
    public int GetScore()
    {
        return score;
    }
}

