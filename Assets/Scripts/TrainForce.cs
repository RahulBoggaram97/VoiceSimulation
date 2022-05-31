using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainForce : MonoBehaviour
{
    Animator anim;
    public int count;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void leftTrain()
    {
        switch(count)
        {
            case 0:
                anim.SetBool("frontTrain1",true);
                anim.SetBool("frontTrain2",false);
                anim.SetBool("frontTrain3",false);
                count++;
                break;
            case 1:
                anim.SetBool("frontTrain1", false);
                anim.SetBool("frontTrain2", true);
                anim.SetBool("frontTrain3", false);
                count++;
                break;
            case 2:
                anim.SetBool("frontTrain1", false);
                anim.SetBool("frontTrain2", false);
                anim.SetBool("frontTrain3", true);
                count++;
                break;

        }
    }

    public void rightTrain()
    {
        switch (count)
        {
            case 0:
                anim.SetBool("downTrain1", true);
                anim.SetBool("downTrain2", false);
                anim.SetBool("downTrain3", false);
                count++;
                break;
            case 1:
                anim.SetBool("downTrain1", false);
                anim.SetBool("downTrain2", true);
                anim.SetBool("downTrain3", false);
                count++;
                break;
            case 2:
                anim.SetBool("downTrain1", false);
                anim.SetBool("downTrain2", false);
                anim.SetBool("downTrain3", true);
                count++;
                break;

        }
    }
}
