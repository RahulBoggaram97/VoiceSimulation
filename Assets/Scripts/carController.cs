using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class carController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoretext;
    Rigidbody2D car;

    int score = 0;
    public char actions;

    bool dead = false;

    void Start()
    {
        car = transform.GetComponent<Rigidbody2D>();
       
    }

    //Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown("space") && !dead)
    //    {
    //        car.velocity = new Vector2(1f, 0);
    //    }
    //}

    public void carMoveleft()
    {
        car.velocity = new Vector2(2f, 0);
    }

    public void carRight()
    {
        car.velocity = new Vector2(-2f, 0);
    }
    //void OnCollisionEnter2D()
    //{
    //    dead = true;
    //    score = 0;
    //    scoretext.text = "0";
    //}

    //private void OnTriggerExit2D(Collider2D col)
    //{
    //    if(col.gameObject.tag == "PointTrigger")
    //    {
    //        score++;
    //        scoretext.text = score.ToString();
    //    }
    //}
    
}
