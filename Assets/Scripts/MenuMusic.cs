using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusic : MonoBehaviour {

    static bool AudioBegin = false;
    void Awake()
    {
        if (!AudioBegin)
        {
            gameObject.GetComponent<AudioSource>().Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "Centering")
        {
            gameObject.GetComponent<AudioSource>().Stop();
            AudioBegin = false;
        }
    }
}
