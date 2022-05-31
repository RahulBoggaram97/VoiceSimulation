﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScript : MonoBehaviour {

    public float JumpForce;

    [SerializeField]
    bool isGrounded = false;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        if (isGrounded == true)
    //        {
    //            rb.AddForce(Vector2.up * JumpForce);
    //            isGrounded = false;
    //        }
    //    }
    //    }
    public void girlJump()
    {
        //if (isGrounded == true)
        {
            rb.AddForce(Vector2.up * JumpForce);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("ground"))
            {
                if (isGrounded == false)
                {
                    isGrounded = true;
                }
            }
        }
    }

