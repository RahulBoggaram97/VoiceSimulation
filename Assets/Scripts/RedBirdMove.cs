using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBirdMove : MonoBehaviour
{
    Animator anim;
    public int count;
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
   public void birdRED()
    {
        switch (count)
            
        {
            case 0:
                anim.SetBool("redBirdMove", true);
                anim.SetBool("redBird1", false);
                anim.SetBool("redBird2", false);
                anim.SetBool("redBird3", false);
                anim.SetBool("redBird4", false);
                count++;
                break;

            case 1:
                anim.SetBool("redBirdMove",false);
                anim.SetBool("redBird1", true);
                anim.SetBool("redBird2", false);
                anim.SetBool("redBird3", false);
                anim.SetBool("redBird4", false);
                count++;
                break;

            case 2:
                anim.SetBool("redBirdMove", false);
                anim.SetBool("redBird1", false);
                anim.SetBool("redBird2", true);
                anim.SetBool("redBird3", false);
                anim.SetBool("redBird4", false);
                count++;
                break;

            case 3:
                anim.SetBool("redBirdMove", false);
                anim.SetBool("redBird1", false);
                anim.SetBool("redBird2", false);
                anim.SetBool("redBird3", true);
                anim.SetBool("redBird4", false);
                count++;
                break;

            case 4:
                anim.SetBool("redBirdMove", false);
                anim.SetBool("redBird1", false);
                anim.SetBool("redBird2", false);
                anim.SetBool("redBird3", false);
                anim.SetBool("redBird4", true);
                count++;
                break;
        }
        
    }
}
