using UnityEngine;
using UnityEngine.Events;

public class ShieldScore : MonoBehaviour
{
    [SerializeField] private int shieldScore; // Current score for the shield
    [SerializeField] private int finalShieldScore; // Score needed for the shield to win
    [SerializeField] private UnityEvent onShieldWin; // Actions to perform when the shield wins

    // Method to update the shield score
    public void UpdateShieldScore()
    {
        shieldScore++; // Increment the shield score by 1
        if (shieldScore >= finalShieldScore) // Check if the shield score has reached or exceeded the final score
        {
            onShieldWin.Invoke(); // Invoke the shield win event
        }
    }

    // Method to reset the shield score
    public void ResetShieldScore()
    {
        shieldScore = 0; // Reset the shield score to 0
    }

    // Method to get the current shield score
    public int GetShieldScore()
    {
        return shieldScore;
    }
}
