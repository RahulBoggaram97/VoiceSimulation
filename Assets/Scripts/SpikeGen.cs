using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGen : MonoBehaviour
{
    public GameObject spike;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;
    void Awake()
    {
        currentSpeed = MinSpeed;
        generateSpike();
    }

    public void generateSpikesWithGap()
    {
        float randomWait = Random.Range(0.1f, 2f);
        Invoke("generateSpike", randomWait);
    }

    // Update is called once per frame
    public void generateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);

        SpikeIns.GetComponent<SpikeMove>().spikeGenerator = this; 
    }

    private void Update()
    {
        if(currentSpeed < MaxSpeed )
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}
