using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleSys : MonoBehaviour
{
    ParticleSystem smoke;
    void Start()
    {
        smoke = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    public void trainSmoke()
    {
        smoke.Play();
    }

    public void orange()
    {
        smoke.Play();
    }

    //public void blue()
    //{
    //    water.Play();
}

