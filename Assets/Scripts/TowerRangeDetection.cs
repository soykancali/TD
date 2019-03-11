using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TowerRangeDetection : Singleton<TowerRangeDetection>
{
    public GameObject bullet;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("monster"))
        {
            Debug.Log("monster");
            Instantiate(bullet, this.transform.position, Quaternion.identity).GetComponent<BulletMove>().targePosition = other.transform.position;

        }
        
    }}
