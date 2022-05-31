using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMove : MonoBehaviour
{
    public SpikeGen spikeGenerator;
    void Start()
    {
        
    }

  

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * spikeGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("NextLine"))
        {
            spikeGenerator.generateSpikesWithGap();
        }

        if (collision.gameObject.CompareTag("FinishLine"))
        {
            Destroy(this.gameObject);
        }
    }
}
