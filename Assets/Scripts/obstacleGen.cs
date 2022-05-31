using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleGen : MonoBehaviour {

    [SerializeField] GameObject pipes;

    int timer = 10;
	void Start () {
		
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        timer ++;
        if(timer >= 300)
        {
            timer = 0;
            GameObject pipe = Instantiate(pipes, new Vector2(pipes.transform.position.x, pipes.transform.position.y + Random.Range(-1, 1)), pipes.transform.rotation);
        }
    }
}
