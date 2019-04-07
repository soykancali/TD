using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TowerRangeDetection : Singleton<TowerRangeDetection>
{
    public GameObject bullet;
    public static float fireRate = 2f,nextFire;
    
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag.Equals("monster"))
        {
           
            

                Debug.Log("monster");
                Instantiate(bullet, this.transform.position, Quaternion.identity).GetComponent<BulletMove>().targePosition = other.transform.position;

            
        }
    }
    //public void OnTriggerStay2D(Collider2D other)
    //{
    //    if (other.tag.Equals("monster"))
    //    {
    //        Instantiate(bullet, this.transform.position, Quaternion.identity).GetComponent<BulletMove>().targePosition = other.transform.position;

    //    }
    //}

}
