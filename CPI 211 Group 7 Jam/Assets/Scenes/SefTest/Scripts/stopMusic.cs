using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stopMusic : MonoBehaviour
{
    public AudioSource[] sources;
    public float[] volumes;
    void Start()
    {
        for (int i = 0; i < sources.Length; i++)
        {
            volumes[i] = sources[i].volume;
            Debug.Log(sources[i] + " volume: " + volumes[i]);
        }
    }


    void Update()
    {
        if (SceneManager.sceneCount >= 2)
        {
            for (int i = 0; i < sources.Length; i++)
            {
                sources[i].volume = 0.0f;
            }
        }

        else
        {
            for (int i = 0; i < sources.Length; i++)
            {
                sources[i].volume = volumes[i];
            }
        }
    }
}
