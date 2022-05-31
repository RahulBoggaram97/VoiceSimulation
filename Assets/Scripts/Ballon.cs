using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour {

    Animator anim;
    public int num;
	void Start ()
    {
        anim = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	public void balloon1 ()
    {
        anim.SetBool("newBalloon1",true);	
	}

    public void balloon2()
    {
        switch (num)
        {
            case 0:
                anim.SetBool("newBalloon2", true);
                anim.SetBool("newBalloon3", false);
                num++;
                break;


            case 1:
                anim.SetBool("newBalloon2", false);
                anim.SetBool("newBalloon3", true);
                num++;
                break;
        }
    }

    public void balloon3()
    {
        anim.SetBool("newBalloon4", true);
    }

    public void blueBall()
    {
        anim.SetBool("blueBall", true);
    }

    public void redBall()
    {
        anim.SetBool("redball", true);
    }

    public void yellowBall()
    {
        anim.SetBool("yellowBall", true);
    }

    //public void balloonThree()
    //{
    //    switch (num)
    //    {
    //        case 0:
    //            anim.SetBool("newBalloon4", true);
    //            anim.SetBool("newBalloon5", false);
    //            num++;
    //            break;


    //        case 1:
    //            anim.SetBool("newBalloon4", false);
    //            anim.SetBool("newBalloon5", true);
    //            num++;
    //            break;
    //    }
    //}

    public void balloonfour()
    {
        anim.SetBool("Balloon4", true);
    }

    public void BallonDes3()
    {
        anim.SetBool("newBalloon5", true);
    }

    public void ball()
    {
        transform.Translate(2, 0, 0);
    }
}
