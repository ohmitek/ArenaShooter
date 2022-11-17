using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public Transform[] spawnPoints; // List of spawnpoints
    public GameObject[] enemyPrefabs; // List of enemies
    
    // Start is called before the first frame update
    void Start()
    {
        Spawn(); //Spawn 20 enemies at start of the game.
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0) // if there is no enemies do Spawn() and +20 new enemies.
        {
            Spawn();
        }
     
    }
    
    private void Spawn() // This spawns the enemies between random spawnpoints.
    {
        int ammount = 20; // Ammount of the enemies to spawn.
        for (int i = 1; i < ammount; i++)
        {
            int randEnemy = Random.Range(0,enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0,spawnPoints.Length);
            Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
    }
}
