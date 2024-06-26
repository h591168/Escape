using UnityEngine;
using UnityEngine.Events;

public class ScoreAxe : MonoBehaviour
{
    [SerializeField] private int axeScore; // Current score for the axe
    [SerializeField] private int finalAxeScore; // Score needed for the axe to win
    [SerializeField] private UnityEvent onAxeWin; // Actions to perform when the axe wins

    // Method to update the axe score
    public void UpdateAxeScore()
    {
        axeScore++; // Increment the axe score by 1
        if (axeScore >= finalAxeScore) // Check if the axe score has reached or exceeded the final score
        {
            onAxeWin.Invoke(); // Invoke the axe win event
        }
    }

    // Method to reset the axe score
    public void ResetAxeScore()
    {
        axeScore = 0; // Reset the axe score to 0
    }

    // Method to get the current axe score
    public int GetAxeScore()
    {
        return axeScore;
    }
}

