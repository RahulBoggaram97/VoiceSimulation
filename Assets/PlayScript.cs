﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour {

    public float JumpForce;

    [SerializeField]
    bool isGrounded = false;

    Rigidbody2D rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}