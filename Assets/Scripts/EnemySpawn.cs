using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    
    public GameObject[] Enemy;
    public Transform[] SpawnPoint;
    [SerializeField]
    public Transform[] capturepoint;
    public int waves = 5;
    int randomSpanwPoint, randomEnemy;
    
   
    void Start()
    {for(int i = 1; i < waves; i++) { 
        InvokeRepeating("SpawnOrc", 1f, 1f);
            
    }
        waves++;
    }

    private void SpawnOrc()
    {
        randomSpanwPoint = Random.Range(0,SpawnPoint.Length);
        randomEnemy = Random.Range(0, Enemy.Length);
        Instantiate(Enemy[randomEnemy],SpawnPoint[randomSpanwPoint].position,Quaternion.identity);
        
    }
    private void SpawnBat()
    {
        randomSpanwPoint = Random.Range(0, SpawnPoint.Length);
        randomEnemy = Random.Range(0, Enemy.Length);
        Instantiate(Enemy[randomEnemy], SpawnPoint[randomSpanwPoint].position, Quaternion.identity);

    }

    void Update()
    {
        if(MoveEnemy.reach == 1)
        {
            
        }

    }
}
