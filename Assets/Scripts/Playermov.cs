using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermov : MonoBehaviour {

    public float MovementSpeed = 1;

    private Rigidbody2D rb;
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();	
	}

    // Update is called once per frame
     void Update ()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
	}
}
