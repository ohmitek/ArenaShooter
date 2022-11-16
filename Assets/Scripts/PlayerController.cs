using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Animation
    public Animator animator;

    //Movement varaibles

    public float xRange = 10f;
    public float yRange = 10f;
    public float playerSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 mousePos;
    float movement_y;
    float movement_x;
    public Camera cam;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("movingRight", true);
            animator.SetBool("movingLeft", false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("movingRight", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("movingLeft", true);
            animator.SetBool("movingRight", false);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("movingLeft", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("movingUp", true);
            animator.SetBool("movingDown", false);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("movingUp", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("movingDown", true);
            animator.SetBool("movingUp", false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("movingDown", false);
        }




        movement_x = Input.GetAxis("Horizontal");
        movement_y = Input.GetAxis("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);





    }

    // Update is called once per frame
    void FixedUpdate()
    {

        PlayerMove();


    }

    private void PlayerMove()
    {


        transform.Translate(Vector2.right * movement_x * Time.deltaTime * playerSpeed);

        transform.Translate(Vector2.up * movement_y * Time.deltaTime * playerSpeed);

        if(transform.position.x < - xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
        if (transform.position.y < - yRange)
        {
            transform.position = new Vector2(transform.position.x, - yRange);
        }


        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }






    }







}
