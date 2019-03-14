using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    
    public GameObject[] Enemy;
    public Transform[] SpawnPoint;
    [SerializeField]
    public Transform[] capturepoint;
    public int waves = 3;
    int randomSpanwPoint, randomEnemy;
    public float health;
    public Slider monsterHealth;

    
    
    
    void Start()
    {
        for (int i = 1; i < waves; i++) { 
        InvokeRepeating("SpawnOrc", 1f, 1f);
            
    }
        waves++;
    }

    private void SpawnOrc()
    {
        
       randomSpanwPoint = Random.Range(0,SpawnPoint.Length);
        randomEnemy = Random.Range(0, Enemy.Length);
        Instantiate(Enemy[randomEnemy], SpawnPoint[randomSpanwPoint].position,Quaternion.identity);
        
    }
    private void SpawnBat()
    {
        randomSpanwPoint = Random.Range(0, SpawnPoint.Length);
        randomEnemy = Random.Range(0, Enemy.Length);
        Instantiate(Enemy[randomEnemy], SpawnPoint[randomSpanwPoint].position, Quaternion.identity);

    }

    void Update()
    {
        
        if (MoveEnemy.reach == 1)
        {
            
        }

    }
   
}
