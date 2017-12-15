using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loser : MonoBehaviour {

    public Text lose;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //In the Winner Scene displays who lose with their score.
        if (ScoreBoard.p1Score <  30)
        {
            lose.text = "Player 1              Lost!!            Score    " + ScoreBoard.p1Score;
        }
        else if (ScoreBoard.p2Score < 30)
        {
            lose.text = "Player 2              Lost!!            Score    " + ScoreBoard.p2Score;
        }
	}
}
