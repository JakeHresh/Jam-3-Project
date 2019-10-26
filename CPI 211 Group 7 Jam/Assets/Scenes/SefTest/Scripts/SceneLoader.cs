using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int count = 0;
    private bool paused = false;
    private bool win1;
    private float lose1;

    void Update()
    {
        lose1 = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>().health;
        win1 = GameObject.FindGameObjectWithTag("Player").GetComponent<sceneNav>().win;
        Victory();
        GameOver();
        Menu();
    }

    public void Menu()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale > 0.0f)
            {
                Time.timeScale = 0.0f;
                SceneManager.LoadScene("PauseScene", LoadSceneMode.Additive);
            }
        }
    }

    public void Victory()
    {
        if (win1 == true && count == 0)
        {
            SceneManager.LoadScene("VictoryScene", LoadSceneMode.Additive);
            Time.timeScale = 1.0f;
            count = 1;
        }
    }

    public void GameOver()
    {
        if (lose1 <= 0 && count == 0)
        {
            SceneManager.LoadScene("LoseScene", LoadSceneMode.Additive);
            Time.timeScale = 1.0f;
            count = 1;
        }
    }
}
