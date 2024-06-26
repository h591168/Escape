using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel; // Reference to the Main Menu panel
    public GameObject informationPanel; // Reference to the Information panel

    // Method to load the main game scene
    public void PlayGame()
    {
        SceneManager.LoadScene("Hovedscene");
    }

    // Method to quit the application
    public void QuitGame()
    {
        Application.Quit();
    }

    // Method to show the Information panel and hide the Main Menu panel
    public void ShowInformationPanel()
    {
        if (informationPanel != null && mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(false);
            informationPanel.SetActive(true);
        }
    }

    // Method to hide the Information panel and show the Main Menu panel
    public void HideInformationPanel()
    {
        if (informationPanel != null && mainMenuPanel != null)
        {
            informationPanel.SetActive(false);
            mainMenuPanel.SetActive(true);
        }
    }
}
