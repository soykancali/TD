using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureEnemy : Singleton<CaptureEnemy>
{
    public static int reachedEnemy = 0;
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag.Equals("monster"))
        {
            reachedEnemy++;
            Lifes.instance.setLife();
        }
    }
}
