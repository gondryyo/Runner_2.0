using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{

    public GameObject enemigo;
    public float maxX;
    public float minX;
    public float timeBetweenSpawn;
    private float spawnTime;
      
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);

        Instantiate(enemigo, transform.position + new Vector3(randomX, 0, 0), transform.rotation);
    }
}
