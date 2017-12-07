using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


    void Start()
    {
     
    }

    public void LoadLevel(string levelName)
    {
        print("Loading Level" + levelName);
        SceneManager.LoadScene(levelName);
        SceneManager.LoadScene(levelName);
    }


    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
