using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    public float playerSpeed = 10.0f;

    public GameObject bullet_GameObject;
    public Vector2 current_direction;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //// Making player input available.
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Makes Player game object move across the arena.
        transform.Translate(Vector2.up * verticalInput * Time.deltaTime * playerSpeed);
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * playerSpeed); // return on if not wokring
        //giveCurrentDirection();
        if (Input.GetKeyDown(KeyCode.A))
        {            
            current_direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {           
            current_direction = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {           
            current_direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {           
            current_direction = Vector2.down;
        }





        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet_GameObject, transform.position, Quaternion.identity);
            //current_direction = gameObject.transform.position;

            
        }

    }

    //public Vector2 giveCurrentDirection()
    //{
    //    current_direction = Vector2.up;
    //    return current_direction;
    //}



    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("Trigger");
    //}



    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("Collision!!!"); // Just for debugging. Comment out if 
    //}


}
