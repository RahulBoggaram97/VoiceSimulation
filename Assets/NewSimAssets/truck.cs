using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class truck : MonoBehaviour
{
    Animator anim;

    public int count;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Apples()
    {
        anim.SetBool("newApples", true);
    }

    public void Truck()
    {
        anim.SetBool("newTruck", true);
    }

    public void LoadMyScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("mangoTree");
    }

    public void Mangoes()
    {
        anim.SetBool("newMangoes", true);
    }

    public void MangoTruckMove()
    {
        anim.SetBool("newMangoes", true);
        anim.SetBool("mangoTruckMove", true);
    }

    public void LoadOrangeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("orangeTree");
    }

    public void Orange()
    {
        anim.SetBool("newOranges", true);
    }
    public void OrangeTruckMove()
    {
        anim.SetBool("newTruck3", true);
    }

    public void Mango()
    {
        switch (count)
        {
            case 0:
                anim.SetBool("jumpMonkey", true);
                anim.SetBool("handMonkey", false);
                count++;
                break;

            case 1:
                anim.SetBool("jumpMonkey", false);
                anim.SetBool("handMonkey", true);
                count++;
                break;
        }
    }

    public void stone()
    {
        anim.SetBool("throwStone", true);
    }

    public void downMango()
    {
        anim.SetBool("mangoFall", true);
    }

    public void stoneFall()
    {
        anim.SetBool("newStone", true);
    }

    public void monkeyJump()
    {
        anim.SetBool("jumpMonkey", true);

    }

    public void monkeyHand()
    {
        anim.SetBool("handMonkey", true);
    }


    public void fallCoconuts()
    {
        anim.SetBool("coconutsFall", true);
    }

    public void truckEnd()
    {
        anim.SetBool("cocoTruckEnd", true);
    }

    public void LoadMonkeyScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Monkey");
    }

    public void LoadboyStone()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("boyStone");
    }

    public void downMango2()
    {
        anim.SetBool("2mangoFall", true);
    }


    public void downMango3()
    {
        anim.SetBool("3mangoFall", true);
    }

    //public void Monkey()
    //{
    //    switch (count)
    //    {
    //        case 0:
    //            anim.SetBool("jumpMonkey", true);
    //            anim.SetBool("handMonkey", false);
    //            count++;
    //            break;

    //        case 1:
    //            anim.SetBool("jumpMonkey", false);
    //            anim.SetBool("handMonkey", true);
    //            count++;
    //            break;
    //    }
    //}
}
