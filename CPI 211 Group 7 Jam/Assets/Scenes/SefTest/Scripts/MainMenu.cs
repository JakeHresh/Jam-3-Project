using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SefTestScene");
        Time.timeScale = 1.0f;
    }

    public void Options()
    {
        SceneManager.LoadScene("OptionScene");
        Time.timeScale = 1.0f;
    }
    public void Return()
    {
        SceneManager.LoadScene("StartScene");
        Time.timeScale = 1.0f;
    }

    public void Resume()
    {
        SceneManager.UnloadSceneAsync("PauseScene");
        Time.timeScale = 1.0f;
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
