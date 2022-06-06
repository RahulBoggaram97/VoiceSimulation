using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horseanim : MonoBehaviour
{
    Animator anim;

    public int count;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void jumpingHorse()
    {
        anim.Play("horseRun");
    }

    public void switchHorse()
    {
        switch (count)
        {
            case 0:
                anim.SetBool("horseRunning", true);
                anim.SetBool("horseRunning2", false);
                anim.SetBool("horseRunning3", false);
                count++;
                break;

            case 1:
                anim.SetBool("horseRunning", false);
                anim.SetBool("horseRunning2", true);
                anim.SetBool("horseRunning3", false);
                count++;
                break;

            case 2:
                anim.SetBool("horseRunning", false);
                anim.SetBool("horseRunning2", false);
                anim.SetBool("horseRunning3", true);
                count++;
                break;
        }
            

    }
}
