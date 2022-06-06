using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carAnimScript : MonoBehaviour
{
    Animator anim;
    public int count;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void redCar()
    {
        switch (count)
        {
            case 0:
                anim.SetBool("carRedMove", true);
                anim.SetBool("carRedMove1", false);
                anim.SetBool("carRedDown1", false);
                //anim.SetBool("carRedMove2", false);
                anim.SetBool("carRedMove3", false);
                anim.SetBool("carRedMove4", false);
                count++;
                break;

            case 1:
                anim.SetBool("carRedMove", false);
                anim.SetBool("carRedMove1", true);
                anim.SetBool("carRedDown1", false);
                //anim.SetBool("carRedMove2", false);
                anim.SetBool("carRedMove3", false);
                anim.SetBool("carRedMove4", false);
                count++;
                break;

            case 2:
                anim.SetBool("carRedMove", false);
                anim.SetBool("carRedMove1", false);
                anim.SetBool("carRedDown1", true);
                //anim.SetBool("carRedMove2", false);
                anim.SetBool("carRedMove3", false);
                anim.SetBool("carRedMove4", false);
                count++;
                break;

            case 3:
                anim.SetBool("carRedMove", false);
                anim.SetBool("carRedMove1", false);
                anim.SetBool("carRedDown1", false );
                //anim.SetBool("carRedMove2", true);
                anim.SetBool("carRedMove3", true);
                anim.SetBool("carRedMove4", false);
                count++;
                break;

            case 4:
                anim.SetBool("carRedMove", false);
                anim.SetBool("carRedMove1", false);
                anim.SetBool("carRedDown1", false);
                //anim.SetBool("carRedMove2", false);
                anim.SetBool("carRedMove3", false);
                anim.SetBool("carRedMove4", true);
                count++;
                break;

            //case 5:
            //    anim.SetBool("carRedMove", false);
            //    anim.SetBool("carRedMove1", false);
            //    anim.SetBool("carRedDown1", false);
            //    //anim.SetBool("carRedMove2", false);
            //    anim.SetBool("carRedMove3", false);
            //    anim.SetBool("carRedMove4", true);
            //    count++;
                //break;


        }
    }
    
    public void redCarScene()
    {
        SceneManager.LoadScene("carMoveSim");
    }

    public void blueCarScene()
    {
        SceneManager.LoadScene("BlueMoveSim");
    }

    public void horsey()
    {
        switch (count)
        {
            case 0:
                anim.SetBool("runHorse", true);
                anim.SetBool("runHorse2", false);
                anim.SetBool("runHorse3", false);
                anim.SetBool("runHorse4", false);
                //anim.SetBool("carRedMove4", false);
                count++;
                break;

            case 1:
                anim.SetBool("runHorse", false);
                anim.SetBool("runHorse2", true);
                anim.SetBool("runHorse3", false);
                anim.SetBool("runHorse4", false);
                //anim.SetBool("carRedMove4", false);
                count++;
                break;

            case 2:
                anim.SetBool("runHorse", false);
                anim.SetBool("runHorse2", false);
                anim.SetBool("runHorse3", true);
                anim.SetBool("runHorse4", false);
                //anim.SetBool("carRedMove4", false);
                count++;
                break;

            case 3:
                anim.SetBool("runHorse", false);
                anim.SetBool("runHorse2", false);
                anim.SetBool("runHorse3", false);
                anim.SetBool("runHorse4", true);
                //anim.SetBool("carRedMove4", false);
                count++;
                break;
        }
    }

    public void runHorse()
    {
        anim.SetBool("horseRunning", true);
    }
}

