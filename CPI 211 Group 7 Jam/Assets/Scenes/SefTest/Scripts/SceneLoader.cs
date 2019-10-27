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
    public float currentTime, endTime = 60f;

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Sample")
        {
            lose1 = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>().health;
            win1 = GameObject.FindGameObjectWithTag("Player").GetComponent<sceneNav>().win;
            Victory();
            GameOver();
        }

        Menu();
        CheckIntro();
    }

    public void CheckIntro()
    {
        if(SceneManager.GetActiveScene().name == "IntroScene")
        {
            if(count == 0)
            {
                currentTime = 0f;
                count = 1;
            }

            else
            {
                if(currentTime >= endTime)
                {
                    SceneManager.LoadScene("Sample");
                    count = 0;
                }

                else
                {
                    currentTime += 1 * Time.deltaTime;
                }
            }
           
        }
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
            Time.timeScale = 0.0f;
            count = 1;
        }
    }

    public void GameOver()
    {
        if (lose1 <= 0 && count == 0)
        {
            SceneManager.LoadScene("LoseScene", LoadSceneMode.Additive);
            Time.timeScale = 0.0f;
            count = 1;
        }
    }
}
