using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour
{
    Rigidbody rb;
    Collider cd;
    Animator anim;
    int healthPoints = 100;
    bool isDead, isWalking;
   
    // Vector3 localscale;
    void Start()
    {
        anim.SetTrigger("walk");
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
       // localscale = transform.localScale;

        
    }

   
    void Update()
    {
        SetAnimationState();
        Debug.Log("anim",anim);
        
    }
    void SetAnimationState()
    {
        if (MoveEnemy.moveSpeed > 0.1f)
        {
            anim.SetBool("isWalking",true);
            anim.SetBool("isDead",false);
        }
        if(MoveEnemy.moveSpeed==0 && healthPoints>0)
        {
            anim.SetBool("isAttacking",true);
            anim.SetBool("isWalking",false);
        }
        if(MoveEnemy.moveSpeed==0 && healthPoints==0)
        {
            anim.SetBool("isDead",true);
            anim.SetBool("isWalking",false);

        }
    }
    
     private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name.Equals("bullet"))
        {
            healthPoints -= 1;
        }

        if (col.gameObject.name.Equals("bullet") && healthPoints > 0)
        {
            anim.SetTrigger("isWalking");          
            
        }
        else
        {
            
            isDead = true;
            anim.SetTrigger("isDead");
        }
    }
}
