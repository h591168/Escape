using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private float totalTime = 300f; // Total time in seconds
    [SerializeField] private TMP_Text displayText;
    [SerializeField] private GameOverPanelController gameOverPanelController; // Reference to the panel controller

    private float currentTime;

    private void Start()
    {
        currentTime = totalTime;
        Time.timeScale = 1;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        float displayTime = Mathf.Round(currentTime);

        if (currentTime <= 0)
        {
            displayText.text = "Game Over";
            if (gameOverPanelController != null)
            {
                Debug.Log("Showing Game Over Panel");
                gameOverPanelController.ShowGameOverPanel(); // Show the panel
            }
            else
            {
                Debug.LogWarning("GameOverPanelController is not assigned.");
            }
            Time.timeScale = 0;
        }
        else
        {
            displayText.text = displayTime.ToString() + "s";
        }
    }
}
