using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnManager : MonoBehaviour
{
    public Enemy block;
    public BossEnemy bossBlock;
    public Text text;

    
    private Vector3 currentSpeed;
    private float timeSpawn = 0.5f;
    private float timeBoss = 0;
    private int score;
    private string textScore;
  
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", timeSpawn, timeSpawn);
        currentSpeed = block.move.getRB().velocity;
        score = 0;
    }
   

    void Spawn()
    {
        timeBoss++;
        
        var posX = Random.Range(-455f,455f);
        var position = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth/2+posX, 0, 7));
        position.z = 0;
        if (timeBoss >= 3)
        {
            timeBoss = 0;
             Instantiate(bossBlock.gameObject, position, Quaternion.identity).GetComponent<BossEnemy>();
         
        }
        else
        {
            var enemy = Instantiate(block.gameObject, position, Quaternion.identity).GetComponent<Enemy>();
            enemy.move.getRB().velocity = currentSpeed;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        textScore = "Score: " + score.ToString();
        currentSpeed += new Vector3(0,0.00009f,0);
        text.text = textScore;
    }

    public void increaseScore()
    {
        score++;
    }
}
