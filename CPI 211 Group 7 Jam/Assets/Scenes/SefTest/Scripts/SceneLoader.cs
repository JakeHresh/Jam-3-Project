using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int count = 0;
    private bool win1;
    private float lose1;

    void Update()
    {
        lose1 = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>().health;
        win1 = GameObject.FindGameObjectWithTag("Player").GetComponent<sceneNav>().win;
        Victory();
        GameOver();
    }

    public void Menu()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Menu will be here");
        }
    }

    public void Victory()
    {

        if (win1 == true && count == 0)
        {
            SceneManager.LoadScene("VictoryScene", LoadSceneMode.Additive);
            count = 1;
        }
    }

    public void GameOver()
    {
        if(lose1 <= 0 && count == 0)
        {
            SceneManager.LoadScene("LoseScene", LoadSceneMode.Additive);
            count = 1;
        }
    }
}
