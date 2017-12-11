using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObsticales : MonoBehaviour {

    public static int movespeed = 3;
    public Vector3 userDirection = Vector3.up;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(userDirection * movespeed * Time.deltaTime); 

	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "TopCollider")
        {
            userDirection = Vector3.down; 
        }
        else if (coll.gameObject.name == "BottomCollider")
        {
            userDirection = Vector3.up;
        }
    }
}
