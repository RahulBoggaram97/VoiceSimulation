using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x-1f, transform.position.y), 0.002f);
	}
}
