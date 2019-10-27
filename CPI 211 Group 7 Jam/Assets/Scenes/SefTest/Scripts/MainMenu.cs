using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Sample");
        
    }

    public void Intro()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("IntroScene");
    }

    public void Options()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("OptionScene");
    }
    public void Return()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("StartScene");
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        SceneManager.UnloadSceneAsync("PauseScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
