using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bullet_Speed = 0.1f;
    private Vector2 shootDirrection; // we need shooting dirrecton. 


    // Start is called before the first frame update
    void Start()
    {

        //shootDirrection = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().giveCurrentDirection();
        shootDirrection = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().current_direction;
        StartCoroutine(DestroyBullet());
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Vector3 position = transform.position;
        //position.x += bullet_Speed;
        //transform.position = position;

        gameObject.transform.Translate(shootDirrection * Time.deltaTime * bullet_Speed);


    }
    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
