using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckJump : MonoBehaviour
{
    Animator anim;
    public int count;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Ducks()
    {
        switch (count)

        {
            case 0:
                anim.SetBool("newDuck1", true);
                anim.SetBool("newDuck2", false);
                anim.SetBool("newDuck3", false);
                anim.SetBool("newDuck4", false);
                //anim.SetBool("duckEat", false);
                count++;
                break;

            case 1:
                anim.SetBool("newDuck1", false);
                anim.SetBool("newDuck2", true);
                anim.SetBool("newDuck3", false);
                anim.SetBool("newDuck4", false);
                //anim.SetBool("duckEat", false);
                count++;
                break;

            case 2:
                anim.SetBool("newDuck1", false);
                anim.SetBool("newDuck2", false);
                anim.SetBool("newDuck3", true);
                anim.SetBool("newDuck4", false);
                //anim.SetBool("duckEat", false);
                count++;
                break;

            case 3:
                anim.SetBool("newDuck1", false);
                anim.SetBool("newDuck2", false);
                anim.SetBool("newDuck3", false);
                anim.SetBool("newDuck4", true);
                //anim.SetBool("duckEat", false);
                count++;
                break;

            //case 4:
            //    anim.SetBool("newDuck1", false);
            //    anim.SetBool("newDuck2", false);
            //    anim.SetBool("newDuck3", false);
            //    anim.SetBool("newDuck4", false);
            //    //anim.SetBool("duckEat", true);
            //    count++;
            //    break;
        }

    }

    public void DucksLev1()
    {
        switch (count)

        {
            case 0:
                anim.SetBool("duckLev1", true);
                anim.SetBool("duckLev2", false);
                anim.SetBool("duckLev3", false);
                count++;
                break;

            case 1:
                anim.SetBool("duckLev1", false);
                anim.SetBool("duckLev2", true);
                anim.SetBool("duckLev3", false);
                count++;
                break;

            case 2:
                anim.SetBool("duckLev1", false);
                anim.SetBool("duckLev2", false);
                anim.SetBool("duckLev3", true);
                count++;
                break;
        }
    }

    public void DucksLev3()
    {
        switch (count)

        {
            case 0:
                anim.SetBool("duckLev3", true);
                anim.SetBool("duckLev32", false);
                anim.SetBool("duckLev34", false);
                anim.SetBool("duckLev35", false);
                anim.SetBool("duckLev36", false);
                count++;
                break;

            case 1:
                anim.SetBool("duckLev3", false);
                anim.SetBool("duckLev32", true);
                anim.SetBool("duckLev34", false);
                anim.SetBool("duckLev35", false);
                anim.SetBool("duckLev36", false);
                count++;
                break;

            case 2:
                anim.SetBool("duckLev3", false);
                anim.SetBool("duckLev32", false);
                anim.SetBool("duckLev34", true);
                anim.SetBool("duckLev35", false);
                anim.SetBool("duckLev36", false);
                count++;
                break;

            case 3:
                anim.SetBool("duckLev3", false);
                anim.SetBool("duckLev32", false);
                anim.SetBool("duckLev34", false);
                anim.SetBool("duckLev35", true);
                anim.SetBool("duckLev36", false);
                count++;
                break;

            case 4:
                anim.SetBool("duckLev3", true);
                anim.SetBool("duckLev32", false);
                anim.SetBool("duckLev34", false);
                anim.SetBool("duckLev35", false);
                anim.SetBool("duckLev36", true);
                count++;
                break;
        }

    }
}
