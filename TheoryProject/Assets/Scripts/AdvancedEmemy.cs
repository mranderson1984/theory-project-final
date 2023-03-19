using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedEmemy : EnemyManager
{
    [SerializeField]
    bool onGround;

    public float JumpSpeed = 90;
    protected override void Move()
    {
        base.Move();
        Jump();
    }
    private void Jump()
    {
        if (onGround)
        {
            onGround = false;
            enemyRb.AddForce(Vector3.up * JumpSpeed);
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }


} 
