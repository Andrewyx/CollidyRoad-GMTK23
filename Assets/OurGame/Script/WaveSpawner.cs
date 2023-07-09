/*
* Script meant to spawn enemies in random waves, given count, and different gameObjects to spawn
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class WaveSpawner : MonoBehaviour
{
    // prefabs of enemies to spawn
    public List<GameObject> enemies;

    // total # of enemies to spawn
    public int totalEnemies;

    // seconds between each spawn
    public float spawnInterval;

    // location to spawn enemies
    public Transform spawnLocation;

    // we want to draw a rectangular spawn area, so we need a y and x size
    public float spawnAreaX;
    public float spawnAreaY;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        // spawn enemies until we reach totalEnemies
        while (totalEnemies > 0)
        {
            var position = spawnLocation.position;
            var spawnPos = new Vector3(
                Random.Range(
                    position.x - spawnAreaX,
                    position.x + spawnAreaX
                ),
                Random.Range(
                    position.y - spawnAreaY,
                    position.y + spawnAreaY
                ),
                position.z
            );

            // pick a random enemy to spawn
            var enemyIndex = Random.Range(0, enemies.Count);
            // spawn the enemy
            Instantiate(
                enemies[enemyIndex],
                spawnPos,
                Quaternion.identity
            );
            // wait for spawnInterval seconds
            yield return new WaitForSeconds(spawnInterval);
            // decrease totalEnemies
            totalEnemies--;
        }
    }
    
}