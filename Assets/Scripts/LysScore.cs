using UnityEngine;
using UnityEngine.Events;

public class LysScore : MonoBehaviour
{
    [SerializeField] private int lysScore; // Current score for the axe
    [SerializeField] private int finalLysScore; // Score needed for the axe to win
    [SerializeField] private UnityEvent onLysWin; // Actions to perform when the axe wins

    // Method to update the axe score
    public void UpdateLysScore()
    {
        lysScore++; // Increment the axe score by 1
        if (lysScore >= finalLysScore) // Check if the axe score has reached or exceeded the final score
        {
            onLysWin.Invoke(); // Invoke the axe win event
        }
    }

    // Method to reset the axe score
    public void ResetLysScore()
    {
        lysScore = 0; // Reset the axe score to 0
    }

    // Method to get the current axe score
    public int GetLysScore()
    {
        return lysScore;
    }
}