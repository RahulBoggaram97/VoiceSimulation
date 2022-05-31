using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeInc : MonoBehaviour
{
    public float speed = 5f;
    Vector3 inc;
    Vector3 siz;
    //Vector2 size;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Square()
    {
        inc = transform.localScale;
        //size = transform.localScale;

        inc.x += 0.002f;
        inc.y += 0.002f;

        transform.localScale = inc;
    }

    public void DecSquare()
    {
        transform.localScale = siz;
        
        if (transform.localScale.x < 1f && transform.localScale.y< 1f)
        {
            return;
        }

        inc = transform.localScale;
        //size = transform.localScale;

        inc.x += -0.002f;
        inc.y += -0.002f;

        transform.localScale = inc;

    }
}
