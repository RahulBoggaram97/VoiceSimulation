using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogAnim : MonoBehaviour {

    Animator animDog;
    public int count;
	void Start ()
    {
        animDog = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	public void dog ()
    {
		switch(count)
        {
            case 0:
                animDog.SetBool("newRun1", true);
                //animDog.SetBool("normalRun", true);
                animDog.SetBool("newStop1", false);
                animDog.SetBool("newRun2", false);
                animDog.SetBool("newStop2", false);
                animDog.SetBool("newRun3", false);
                animDog.SetBool("newStop3", false);
                animDog.SetBool("newRun4", false);
                count++;
                break;
            case 1:
                animDog.SetBool("newRun1", false);
                //animDog.SetBool("normalRun",false);
                animDog.SetBool("newStop1", true);
                animDog.SetBool("newRun2", false);
                animDog.SetBool("newStop2", false);
                animDog.SetBool("newRun3", false);
                animDog.SetBool("newStop3", false);
                animDog.SetBool("newRun4", false);
                count++;
                break;
            case 2:
                animDog.SetBool("newRun1", false);
                animDog.SetBool("newStop1", false);
                animDog.SetBool("newRun2", true);
                animDog.SetBool("newStop2", false);
                animDog.SetBool("newRun3", false);
                animDog.SetBool("newStop3", false);
                animDog.SetBool("newRun4", false);
                count++;
                break;

            case 3:
                animDog.SetBool("newRun1", false);
                animDog.SetBool("newStop1", false);
                animDog.SetBool("newRun2", false);
                animDog.SetBool("newStop2", true);
                animDog.SetBool("newRun3", false);
                animDog.SetBool("newStop3", false);
                animDog.SetBool("newRun4", false);
                count++;
                break;

            case 4:
                animDog.SetBool("newRun1", false);
                animDog.SetBool("newStop1", false);
                animDog.SetBool("newRun2", false);
                animDog.SetBool("newStop2", false);
                animDog.SetBool("newRun3", true);
                animDog.SetBool("newStop3", false);
                animDog.SetBool("newRun4", false);
                count++;
                break;

            case 5:
                animDog.SetBool("newRun1", false);
                animDog.SetBool("newStop1", false);
                animDog.SetBool("newRun2", false);
                animDog.SetBool("newStop2", false);
                animDog.SetBool("newRun3", false);
                animDog.SetBool("newStop3", true);
                animDog.SetBool("newRun4", false);
                count++;
                break;

            case 6:
                animDog.SetBool("newRun1", false);
                animDog.SetBool("newStop1", false);
                animDog.SetBool("newRun2", false);
                animDog.SetBool("newStop2", false);
                animDog.SetBool("newRun3", false);
                animDog.SetBool("newStop3", false);
                animDog.SetBool("newRun4", true);
                count++;
                break;
        }
    }

    //public void dog2()
    //{
    //    switch (count)
    //    {
    //        case 0:
                
    //            animDog.SetBool("newStop1", true);
    //            animDog.SetBool("newStop2", false);
    //            animDog.SetBool("newStop3", false);
                
    //            count++;
    //            break;

    //        case 1:

    //            animDog.SetBool("newStop1", false);
    //            animDog.SetBool("newStop2", true);
    //            animDog.SetBool("newStop3", false);

    //            count++;
    //            break;

    //        case 2:

    //            animDog.SetBool("newStop1", false);
    //            animDog.SetBool("newStop2", false);
    //            animDog.SetBool("newStop3", true);

    //            count++;
    //            break;
    //    }
    //}
}
