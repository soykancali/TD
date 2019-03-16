using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc :Singleton<Orc>
{
    Rigidbody2D rb;
    Collider2D cd;
    Animator anim;
    private float hp;
    bool isDead, isWalking;
    private Vector3 localscale;
   
    // Vector3 localscale;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        cd = GetComponent<Collider2D>();
        //anim.SetTrigger("walk");
        hp = MoveEnemy.Instance.health;
       
        localscale = transform.localScale;

        
    }

   
    void Update()
    {
        SetAnimState();
        Debug.Log("anim",anim);
        
    }
    void SetAnimState()
    {
        if (hp>=0)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isDead", false);
        }
        if(hp <= 0)
                {
            anim.SetBool("isDead", true);
            anim.SetBool("isWalking", false);
        }
       
    }



}
