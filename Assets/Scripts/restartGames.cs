using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGames : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void restartApple()
    {
        SceneManager.LoadScene("appleTree");
    }

    public void endless()
    {
        SceneManager.LoadScene("2DEndless");
    }

    public void basketBall()
    {
        SceneManager.LoadScene("Basketball");
    }
}
