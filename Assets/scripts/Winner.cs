using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour {

    public Text win;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        //In the Winner Scene displays who win with their score.
        if (ScoreBoard.p1Score == 30)
        {
            win.text = "Player 1            Won!!         Score    " + ScoreBoard.p1Score;
        }
        else if (ScoreBoard.p2Score == 30)
        {
            win.text = "Player 2            Won!!         Score    " + ScoreBoard.p2Score;
        }
	}
}
