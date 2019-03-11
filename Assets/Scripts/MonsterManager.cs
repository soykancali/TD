using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MonsterManager : Singleton<MonsterManager>
{
    public float monsterCreateTime = 2f;
    public GameObject Monster;
    public GameObject SpawnPoint;
   
    
    private void Start()
    {for(int i = 0; i < 5; i++) { 
        
        }
        InvokeRepeating("Creator",0,monsterCreateTime);
    }
    void Creator ()
    {
        Instantiate(Monster, SpawnPoint.transform.position, Quaternion.identity);
    }

}
