using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{   //Array for many reference
    public GameObject[] animalPrefabs;//To get the animals prefab with their corresponding index
    private float spawnRangeX = 14;//Animals X axis spawn limit
    private float spawnPosZ = 20;//Animals Z axis spawn starting position
    private float startDelay = 2;//Animals spawn starting time
    private float spawnInterval = 1.5f;//Animals spawn interval

    // Start is called before the first frame update
    void Start()
    {
        //To add start delay and spawn interval for the animals
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void SpawnRandomAnimal()
    {
        //Select a random animals base from the element number
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Position on where the random animal will spawn on the game
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        //Spawn random animal base on the element number
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
