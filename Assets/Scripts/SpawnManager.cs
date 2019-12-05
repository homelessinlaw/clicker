using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject block;
    public Transform[] spawnPoint;
 
    private float timeSpawn = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", timeSpawn, timeSpawn);   
    }


    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoint.Length);
        Instantiate(block, spawnPoint[spawnPointIndex].position, spawnPoint[spawnPointIndex].rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
