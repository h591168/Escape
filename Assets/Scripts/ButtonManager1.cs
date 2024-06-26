using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager1 : MonoBehaviour
{
    // Method to reset the game by reloading the first scene
    public void ResetGame()
    {
        SceneManager.LoadScene("StartScene"); // Loads the scene with index 0
    }

    // Method to exit the game
    public void ExitGame()
    {
        Application.Quit(); // Quits the application
    }
}
