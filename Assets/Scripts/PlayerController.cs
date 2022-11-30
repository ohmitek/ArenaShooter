using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // VFX
    public ParticleSystem walkParticle;

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

    // Camera
    public Camera cam;
 

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            walkParticle.Play();
            AudioManager.instance.Play("walk_hero_sound");
            animator.SetBool("movingRight", true);
            animator.SetBool("movingLeft", false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            walkParticle.Stop();
            animator.SetBool("movingRight", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            AudioManager.instance.Play("walk_hero_sound");
            walkParticle.Play();
            animator.SetBool("movingLeft", true);
            animator.SetBool("movingRight", false);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            walkParticle.Stop();
            animator.SetBool("movingLeft", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            AudioManager.instance.Play("walk_hero_sound");
            walkParticle.Play();
            animator.SetBool("movingUp", true);
            animator.SetBool("movingDown", false);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            walkParticle.Stop();
            animator.SetBool("movingUp", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AudioManager.instance.Play("walk_hero_sound");
            walkParticle.Play();
            animator.SetBool("movingDown", true);
            animator.SetBool("movingUp", false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            walkParticle.Stop();
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
