using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    private Paddle player1Paddle;

    float randomX, randomY;

    private Vector3 paddleToBallVector;

    bool hasStarted = false;

    private void onCollisionEnter2D(Collision2D collision)
    {
        randomX = Random.Range(0f, 0.2f);
        randomY = Random.Range(0f, 0.2f);

        //creating a Vector2 tweak with random X and random Y
        Vector2 tweak = new Vector2(randomX, randomY);

        if (hasStarted)
        {
            //velocity = velocity + tweak
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }

    // Use this for initialization
    void Start()
    {
        player1Paddle = GameObject.FindObjectOfType<Paddle>();

        //The distance between the paddle and the ball
        paddleToBallVector = this.transform.position - player1Paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (!hasStarted) //if (hasStarted == false)
        {
            //moves the ball with the paddle with that distance
            this.transform.position = player1Paddle.transform.position + paddleToBallVector;



            //if left click is pressed
            if (Input.GetMouseButtonDown(0))
            {
                //When left click is pressed the ball starts to move and game game begin
                print("Left Click");
                hasStarted = true;

                //set the velocity of the ball to 2x 10y
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, -5f);

            }


        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //When the ball hits the RightCollider +1 Score for Player 1 and tranform in the middle of the pitch.
        if (coll.gameObject.name == "RightCollider")
        {
            ScoreBoard.p1Score++;
            this.transform.position = new Vector3(-6.68f, 0.95f, -1f);
        }
        //When the ball hits the LeftCollider +1 Score for Player 2 and tranform in the middle of the pitch.
        else if (coll.gameObject.name == "LeftCollider") {
            ScoreBoard.p2Score++;
            this.transform.position = new Vector3(-6.68f, 0.95f, -1f);
        }
    }

}

