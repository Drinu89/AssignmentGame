using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObsticales : MonoBehaviour {

    public static int movespeed = 1;
    public Vector3 userDirection = Vector3.right;

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
            movespeed = -1; 
        }
        else if (coll.gameObject.name == "BottomCollider")
        {
            movespeed = 1;
        }
    }
}
