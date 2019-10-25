using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Update()
    {
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
        if (Input.GetKeyDown("v"))
        {
            SceneManager.LoadScene("VictoryScene", LoadSceneMode.Additive);
        }
    }

    public void GameOver()
    {
        if(Input.GetKeyDown("g"))
        {
            SceneManager.LoadScene("LoseScene", LoadSceneMode.Additive);
        }
    }
}
