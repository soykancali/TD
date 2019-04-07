using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Singleton<Orc>
{
    Rigidbody2D rb;
    Collider2D cd;
    Animator anim;
    public GameObject orc;
    private float hp;
    private Vector3 localscale;
    public bool isDead,isWalking;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cd = GetComponent<Collider2D>();
        anim = gameObject.GetComponent<Animator>();
        //anim.SetTrigger("walk");

    }
    void Update()
    {
        hp = MoveEnemy.Instance.health;
        SetAnimState();
    }
    void SetAnimState()
    {
        Debug.Log("anim");
        if (hp >= 0)
        {
            anim.SetBool("isWalking", true);
            Debug.Log("anim1");
        }
        if (hp <= 1)
        {
            
            Debug.Log("anim2");
            isDead = true;
            anim.SetBool("isWalking", false);
            anim.SetBool("isDead", true);
            anim.SetTrigger("isDead");
        }

    }



}
