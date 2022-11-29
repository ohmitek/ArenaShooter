using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public int ammount;    
    public Transform[] spawnPoints; // List of spawnpoints
    public GameObject[] enemyPrefabs; // List of enemies
    public static int enemyCount;
    public static int spawnCount;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        Spawn(20); //Spawn 20 enemies at start of the game.
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckEnemyCount();
  
        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0) // if there is no enemies do Spawn() and +20 new enemies.
        {
            score+=50; // Score from every finished enemywave
            Spawn(+20);    
        }
     
    }

        public void CheckEnemyCount()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        print("|| Enemies: " + enemyCount + " || Wave: " + spawnCount + " || Score: " + score + " || ");
        
    }
    private void Spawn(int ammount) // This spawns the enemies between random spawnpoints.
    {

        spawnCount+=1;
        for (int i = 1; i < ammount * spawnCount +1; i++)
        {
            int randEnemy = Random.Range(0,enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0,spawnPoints.Length);
            Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
        }
    }
}
