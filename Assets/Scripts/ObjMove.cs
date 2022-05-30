using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour {

    public Transform target;
	void Start () {
		
	}
	
	// Update is called once per frame
	public void move ()
    {
        transform.position = new Vector2(-4.7f, 6.3f);
	}
}
