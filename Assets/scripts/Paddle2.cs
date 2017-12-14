using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour
{

    // Use this for initialization
    /*Vector2 position;
    public float speed = 8.0f;
    public float topBounds = 8.3f;
    public float bottomBounds = -8.3f;
    */public Vector3 startingPosition = new Vector3(8.18f, 0.07f, -1);
    void Start()
    {

       transform.localPosition = (Vector3)startingPosition;

    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInBlocks = (Input.mousePosition.y / Screen.width * 10f) - 5f;
        //Vector3 saves any point in (x,y,z)
        Vector3 paddlePosition = new Vector3(-2.3f, this.transform.position.y, -1f);

        //limit the movement of the paddle.
        paddlePosition.y = Mathf.Clamp(mousePosInBlocks, -5f, +3f);

        //sets the position of the paddle (this) to
        //the paddlePosition
        this.transform.position = paddlePosition;
        //CheckUser1Input();

    }




}
