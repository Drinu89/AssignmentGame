using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    public Text Score;
    public GameObject ball;

    private Paddle player1Paddle;
    private Paddle2 player2Paddle;
    private Vector3 paddleToBallVector;

    public static int p1Score = 0;
    public static int p2Score = 0;

   // bool hasStarted = false;


	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        Score.text = p1Score + " - " + p2Score;

        levelMan();
        
	}

    public void levelMan() { 
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        //When one of the players Score is Scored it will Change the Level and displays who won in the console.
        if (sceneName == "Level1" & p1Score == 5) {
            SceneManager.LoadScene("Level2");
            print("Player 1 Won Level 1");
        }
        else if (sceneName == "Level1" & p2Score == 5)
        {
            SceneManager.LoadScene("Level2");
            print("Player 2 Won Level 1");
        }

        else if (sceneName == "Level2" & p1Score == 15)
        {
            SceneManager.LoadScene("Level3");
            print("Player 1 Won Level 2");
        }
        else if (sceneName == "Level2" & p2Score == 15)
        {
            SceneManager.LoadScene("Level3");
            print("Player 2 Won Level 2");
        }
        else if (sceneName == "Level3" & p1Score == 30) {
            SceneManager.LoadScene("Winner");
            print("Player 1 Won Level 3");
        }
        else if (sceneName == "Level3" & p2Score == 30)
        {
            SceneManager.LoadScene("Winner");
            print("Player 2 Won Level 3");
        }
        
            
        
    }

}
