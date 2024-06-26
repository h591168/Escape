using UnityEngine;

public class GameOverPanelController : MonoBehaviour
{
    public GameObject panel; // The panel to show
    public Transform playerCamera; // The player's camera or XR Rig

    private void Start()
    {
        if (panel != null)
        {
            panel.SetActive(false); // Hide the panel at the start
        }
    }

    public void ShowGameOverPanel()
    {
        if (panel != null && playerCamera != null)
        {
            Debug.Log("Activating Game Over Panel");
            panel.SetActive(true); // Show the panel
            PositionPanelInFrontOfPlayer();
        }
        else
        {
            Debug.LogWarning("Panel or Player Camera is not assigned.");
        }
    }

    private void PositionPanelInFrontOfPlayer()
    {
        // Position the panel in front of the player's camera
        panel.transform.position = playerCamera.position + playerCamera.forward * 2.0f; // Adjust the distance as needed
        panel.transform.LookAt(playerCamera);
        panel.transform.Rotate(0, 180, 0); // Correct the rotation
        Debug.Log("Panel positioned in front of the player.");
    }
}
