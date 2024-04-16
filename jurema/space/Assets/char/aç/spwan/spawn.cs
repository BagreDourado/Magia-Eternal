using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;
    public GameObject enemy;
    public float spawnInterval = 2f;
    private float timeSinceLastSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[randomIndex].position, Quaternion.identity);
            timeSinceLastSpawn = 0f;
        }
    }

}
