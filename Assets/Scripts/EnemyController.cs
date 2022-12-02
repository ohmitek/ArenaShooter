using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // VFX
    public ParticleSystem destroyParticle;
    public ParticleSystem spawnParticle;

    private GameObject Player;
    public float speed;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnParticle, gameObject.transform.position, gameObject.transform.rotation);    
    }

    private void OnTriggerEnter2D(Collider2D col)
    { 
        if (col.gameObject.CompareTag ("Bullet"))
        {
            Instantiate(destroyParticle, gameObject.transform.position, gameObject.transform.rotation);
            AudioManager.instance.Play("death_enemy_sound");
            Destroy (col.gameObject);
            Destroy (gameObject);
        }       
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        
    }
}
