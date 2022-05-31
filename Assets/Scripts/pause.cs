using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    bool isPaused = false;

    public void pauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        //if (isPaused)
        //{
        //    Time.timeScale = 1;
        //    isPaused = false;
        //}
        //else
        //{
        //    Time.timeScale = 0;
        //    isPaused = true;
        //}
    }

    public void playGame()
    {
        Time.timeScale = 1;
        isPaused = false;
    }
}
