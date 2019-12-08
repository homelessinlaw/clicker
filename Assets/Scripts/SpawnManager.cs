using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Enemy block;

    float currentSpeed;
    private float timeSpawn = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", timeSpawn, timeSpawn);   
        currentSpeed = block.move.speed;
    }
   

    void Spawn()
    {
        var posX = Random.Range(-455f,455f);
        var position = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth/2+posX, 0, 7));
        position.z = 0;
        var enemy = Instantiate(block.gameObject, position, Quaternion.identity).GetComponent<Enemy>();
        enemy.move.speed = currentSpeed;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed += 0.00009f;
    }
}
