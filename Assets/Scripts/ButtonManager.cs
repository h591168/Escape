using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Method to reset the game by reloading the first scene
    public void ResetGame()
    {
        SceneManager.LoadScene("Hovedscene"); // Loads the scene with index 0
    }

    // Method to exit the game
    public void ExitGame()
    {
        Application.Quit(); // Quits the application
    }
}
