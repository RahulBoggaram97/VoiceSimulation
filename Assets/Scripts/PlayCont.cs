using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCont : MonoBehaviour {

    Rigidbody2D playerController;
	void Start ()
    {
        playerController = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	public void player ()
    {
        playerController.velocity = new Vector2(0, 5f);
	}
}
