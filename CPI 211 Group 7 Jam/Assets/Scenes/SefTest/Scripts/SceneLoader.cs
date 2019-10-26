using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int count = 0;
    public bool win1;

    void Update()
    {
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

        if (Input.GetKeyDown("v") || win1 == true && count == 0)
        {
            SceneManager.LoadScene("VictoryScene", LoadSceneMode.Additive);
            count = 1;
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
