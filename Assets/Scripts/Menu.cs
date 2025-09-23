using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Difficulty buttons
    public void PlayEasy()
    {
        SceneManager.LoadScene("Easy");
    }

    public void PlayMedium()
    {
        SceneManager.LoadScene("Medium");
    }

    public void PlayHard()
    {
        SceneManager.LoadScene("Hard");
    }

    // Back to Menu button (for gameplay scenes)
    public void BackToMenu()
    {
        Time.timeScale = 1f; // Ensure game is unpaused
        SceneManager.LoadScene("Menu");
    }

    // Quit button
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
