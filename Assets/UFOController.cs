﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

    //Add Variables here
    public Rigidbody2D theRB2d;
    public float movementSpeed;


	// Use this for initialization
	void Start () {
        theRB2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		//Add Movement Code Here
		if(Input.GetKeyDown(KeyCode.W))
        {
            theRB2d.velocity += new Vector2(0f, 1.0f) * movementSpeed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            theRB2d.velocity += new Vector2(0f, -1.0f) * movementSpeed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            theRB2d.velocity += new Vector2(-1.0f, 0f  ) * movementSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            theRB2d.velocity += new Vector2(1.0f, 0.0f) * movementSpeed;
        }
    }
}
