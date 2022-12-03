using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // VFX
    public ParticleSystem destroyParticle;
    public ParticleSystem spawnParticle;

    // ENEMY
    private GameObject Player;
    public float speed; // Every enemy has different speed
    private float distance;
    public int enemyHP_number; // Every enemy has different HP number

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnParticle, gameObject.transform.position, gameObject.transform.rotation);    
    }

    // ENEMYDEATH
    private void OnTriggerEnter2D(Collider2D col)
    { 
        if (col.gameObject.CompareTag ("Bullet"))
        {
            enemyHP_number -= 50; // Everytime bullet collade, the HP number decrease.
            Destroy (col.gameObject);
            if (enemyHP_number == 0)
            {
                Instantiate(destroyParticle, gameObject.transform.position, gameObject.transform.rotation);
                AudioManager.instance.Play("death_enemy_sound");
                Destroy (gameObject);
            }
           
        }       
    }

    // Update is called once per frame
    // ENEMYCHASE
    void Update()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
        
    }
}
