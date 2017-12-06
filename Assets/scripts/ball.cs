using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    private Paddle player1Paddle;

    float randomX, randomY;

    private Vector3 paddleToBallVector;

    bool hasStarted = false;

   // private int p1Score = 0;
   // private int p2Score = 0;



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

        //saves the distance between the ball and the paddle
        paddleToBallVector = this.transform.position - player1Paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {



        if (!hasStarted) //if (hasStarted == false)
        {
            //moves the ball with the paddle keeping the distance
            this.transform.position = player1Paddle.transform.position + paddleToBallVector;



            //if left click is pressed
            if (Input.GetMouseButtonDown(0))
            {
                print("Left Click");
                hasStarted = true;

                //set the velocity of the ball to 2x 10y
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, -5f);

            }


        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "RightCollider")
        {
            Debug.Log("Right");
            ScoreBoard.p1Score++;
            this.transform.position = new Vector3(-6.68f, 0.95f, -1f);
        }
        else if (coll.gameObject.name == "LeftCollider") {
            Debug.Log("Left");
            ScoreBoard.p2Score++;
            this.transform.position = new Vector3(-6.68f, 0.95f, -1f);
        }
    }

   /* void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "RightCollider")
        {
            print("P1 + 1");
            p1Score += 1;
        }
        if (col.gameObject.tag == "LeftCollider")
        {
            print("P2 + 1");
            p2Score += 1;
            
        }
    }*/
}

