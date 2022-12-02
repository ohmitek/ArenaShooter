using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimToShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Camera cam;
    public float aimSpeed = 5f;
    public Rigidbody2D aim_rb;
    private Vector2 mousePos;
    public static int shotsound = 0;


    public float bulletForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetButtonDown("Fire1"))
        {
            shotsound += 1;
            Shoot();
            AudioManager.instance.Play("blaster_sfx");
            if (shotsound == 15)
            {
                AudioManager.instance.Play("shot_sound");
                shotsound = 0;
            }
            
        }


    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - aim_rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        aim_rb.rotation = angle;
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D bullet_rb = bullet.GetComponent<Rigidbody2D>();
        bullet_rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Stop");
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        }

    }
}
