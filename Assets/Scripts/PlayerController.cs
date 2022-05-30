using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoretext;
    Rigidbody2D bird;

    int score = 0;

    bool dead = false;

    void Start()
    {
        bird = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown("space") && !dead)
    //    {
    //        bird.velocity = new Vector2(0, 8.5f);
    //    }
    //}

    public void Flappy()
    {
        bird.velocity = new Vector2(0, 12f);
    }
    void OnCollisionEnter2D()
    {
        dead = true;
        score = 0;
        scoretext.text = "0";
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "PointTrigger")
        {
            score++;
            scoretext.text = score.ToString();
        }
    }
}
