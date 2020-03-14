using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float timeBetweenSpawns = 3f;
    float timePassed = 0;
    float NumEnemies = 0;
    public float MaxEnemies = 15f;

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if (NumEnemies < MaxEnemies)
        {
            if (timePassed > timeBetweenSpawns)
            {
                timePassed = 0;
                Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
                NumEnemies++;
            }
        }
    }

    
}
