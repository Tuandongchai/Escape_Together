using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlRombieState : Jumpscare
{
    [SerializeField] protected Animator anim; 
    protected enum girlState
    {
        Idle,
        Walk,
        Run,
        Attack,
        Scream
    }
    protected girlState state;
    protected virtual void UpdateAnimaion()
    {
        switch (state)
        {
            case girlState.Idle:
                anim.SetBool("Idle", true);
                anim.SetBool("Walk", false);
                anim.SetBool("Run", false);
                anim.SetBool("Attack", false);
                anim.SetBool("Scream", false);
                break;
            case girlState.Walk:
                anim.SetBool("Idle", false);
                anim.SetBool("Walk", true);
                anim.SetBool("Run", false);
                anim.SetBool("Attack", false);
                anim.SetBool("Scream", false);
                break;
            case girlState.Run:
                anim.SetBool("Idle", false);
                anim.SetBool("Walk", false);
                anim.SetBool("Run", true);
                anim.SetBool("Attack", false);
                anim.SetBool("Scream", false);
                break;
            case girlState.Attack:
                anim.SetBool("Idle", false);
                anim.SetBool("Walk", false);
                anim.SetBool("Run", false);
                anim.SetBool("Attack", true);
                anim.SetBool("Scream", false);
                break;
            case girlState.Scream:
                anim.SetBool("Idle", false);
                anim.SetBool("Walk", false);
                anim.SetBool("Run", false);
                anim.SetBool("Attack", false);
                anim.SetBool("Scream", true);
                break;
            default:
                anim.SetBool("Idle", true);
                anim.SetBool("Walk", false);
                anim.SetBool("Run", false);
                anim.SetBool("Attack", false);
                anim.SetBool("Scream", false);
                break;
        }


    }
}
