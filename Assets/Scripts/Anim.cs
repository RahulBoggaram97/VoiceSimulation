using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour {

    Animator anim;
    public int count;
	void Start ()
    {
        anim = GetComponent<Animator>(); 
	}

    // Update is called once per frame
    public void Gas()
    {
        switch(count )
        {
            case 0:
                anim.SetBool("newBool1", true);
                anim.SetBool("newBool2", false);
                anim.SetBool("newBool3", false);
                anim.SetBool("newBool4", false);
                anim.SetBool("newBool5", false);
                count++;
                break;
            case 1:
                count++;
                anim.SetBool("newBool1", false);
                anim.SetBool("newBool2", true);
                anim.SetBool("newBool3", false);
                anim.SetBool("newBool4", false);
                anim.SetBool("newBool5", false);
                break;

            

            case 2:
                anim.SetBool("newBool1", false);
                anim.SetBool("newBool2", false);
                anim.SetBool("newBool3",  true);
                anim.SetBool("newBool4",  false);
                anim.SetBool("newBool5",  false);
                count++;
                break;

            case 3:
                anim.SetBool("newBool1", false);
                anim.SetBool("newBool2", false);
                anim.SetBool("newBool3", false);
                anim.SetBool("newBool4", true);
                anim.SetBool("newBool5", false);
                count++;
                break;

            case 4:
                anim.SetBool("newBool1", false);
                anim.SetBool("newBool2", false);
                anim.SetBool("newBool3", false);
                anim.SetBool("newBool4", false);
                anim.SetBool("newBool5", true);
                count++;
                break;
        }

    }
    public void Coal()
    {
        switch (count)
        {
            case 0:
                anim.SetBool("coalBool1", true);
                anim.SetBool("coalBool2", false);
                anim.SetBool("coalBool3", false);
                anim.SetBool("coalBool4", false);
                count++;
                break;

            case 1:
                anim.SetBool("coalBool1", false);
                anim.SetBool("coalBool2", true);
                anim.SetBool("coalBool3", false);
                anim.SetBool("coalBool4", false);
                count++;
                break;

            case 2:
                anim.SetBool("coalBool1", false);
                anim.SetBool("coalBool2", false);
                anim.SetBool("coalBool3", true);
                anim.SetBool("coalBool4", false);
                count++;
                break;

            case 3:
                anim.SetBool("coalBool1", false);
                anim.SetBool("coalBool2", false);
                anim.SetBool("coalBool3", false);
                anim.SetBool("coalBool4", true);
                count++;
                break;
        }
    }

    public void Train()
    {
        anim.SetBool("trainMove", true);
    }
}
