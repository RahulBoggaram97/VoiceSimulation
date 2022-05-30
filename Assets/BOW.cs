﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOW : MonoBehaviour {

    public Vector2 direction;

	void Start () {
		
	}
	
	
	void Update ()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 bowPos = transform.position;

        direction = MousePos - bowPos;

        FaceMouse();
	}

    void FaceMouse()
    {
        transform.right = direction;
    }
}
