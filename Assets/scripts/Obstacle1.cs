using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1 : MonoBehaviour {

    public static int movespeed = 3;
    public Vector3 userDirection = Vector3.up;

	// Use this for initialization
	void Start () {
        // X , Y , Z
        transform.Translate(userDirection * movespeed * Time.deltaTime); 
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y >= -5.4f)
        {
            userDirection = Vector3.up;
        }
       /* else if (transform.position.y == 3.29f) {
            userDirection = Vector3.down;
        }*/
	}
}
