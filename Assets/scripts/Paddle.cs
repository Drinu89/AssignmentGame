using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
    Vector2 position;
    public float speed = 8.0f;
    public float topBounds = 8.3f;
    public float bottomBounds = -8.3f;
    public Vector3 startingPosition = new Vector3(-0.81f, 0.02f, -1);
	void Start () {

        transform.localPosition = (Vector3)startingPosition;

	}
	
	// Update is called once per frame
	void Update () {

        //ChekUser1Input method is declared.
        CheckUser1Input();
        
        
	}

    void CheckUser1Input()
    {
        //When you keep holding W button the paddle moves Up
        if (Input.GetKey(KeyCode.W)) {

            if (transform.localPosition.y > topBounds)
            {
                transform.localPosition = new Vector3(transform.localPosition.x, topBounds, transform.localPosition.z);
            }
            else {
                transform.localPosition += Vector3.up * speed * Time.deltaTime;
            }

        }
            //When you keep pressing the S button the paddle moves down
        else if (Input.GetKey(KeyCode.S)) {

            if (transform.localPosition.y < bottomBounds)
            {
                transform.localPosition = new Vector3(transform.localPosition.x, bottomBounds, transform.localPosition.z);
            }
            else
            {
                transform.localPosition += Vector3.down * speed * Time.deltaTime;
            }

        }
    }


    }

