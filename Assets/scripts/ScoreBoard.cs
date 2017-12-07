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

    bool hasStarted = false;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Score.text = p1Score + " - " + p2Score;

        if (p1Score == 5)
        {
            SceneManager.LoadScene("Level2");
        }
        if (p2Score == 5)
        {
            SceneManager.LoadScene("Level2");
        }
	}


}
