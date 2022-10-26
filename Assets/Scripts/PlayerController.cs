using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movement varaibles

    public float playerSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 mousePos;
    float movement_y;
    float movement_x;
    public Camera cam;

    //Shooing variables






    // Start is called before the first frame update
    void Start()
    {


    }

    void Update()
    {
        movement_x = Input.GetAxis("Horizontal");
        movement_y = Input.GetAxis("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


    }

    // Update is called once per frame
    void FixedUpdate()
    {


        transform.Translate(Vector2.right * movement_x * Time.deltaTime * playerSpeed);
        transform.Translate(Vector2.up * movement_y * Time.deltaTime * playerSpeed);

        //Vector2 lookDir = mousePos - rb.position;
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg - 90f;
        //rb.rotation = angle;


    }





}
