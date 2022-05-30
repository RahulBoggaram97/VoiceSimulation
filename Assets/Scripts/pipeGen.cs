using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeGen : MonoBehaviour {

    [SerializeField] GameObject pipes;

    int timer = 100;
	void Start () {
		
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        timer ++;
        if(timer >= 100)
        {
            timer = 0;
            GameObject pipe = Instantiate(pipes, new Vector2(pipes.transform.position.x, pipes.transform.position.y + Random.Range(-2, 2)), pipes.transform.rotation);
        }
    }
}
