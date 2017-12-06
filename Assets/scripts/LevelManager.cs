using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string levelName)
    {
        print("Loading Level" + levelName);
        SceneManager.LoadScene(levelName);
        SceneManager.LoadScene(levelName);
    }

    public void quitGame() 
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
