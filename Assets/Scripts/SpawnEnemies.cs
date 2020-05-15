using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemies;
    public float minX, minY, maxX, maxY;
    public int spawnRate;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = Random.Range(0, enemies.Length);
        Instantiate(enemies[index], getSpawnPos(), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        int enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (enemyCount <= spawnRate)
        {
            index = Random.Range(0, enemies.Length);
            Instantiate(enemies[index], getSpawnPos(), Quaternion.identity);
        }
    }

    Vector2 getSpawnPos()
    {
        Vector2 spawnPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        return spawnPos;
    }
}
