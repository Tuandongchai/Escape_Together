using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlRombie : GirlRombieState
{
    [SerializeField] private Transform[] location;
    private int nextLocation;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float timeDuration;

    
    private void Awake()
    {
        state = girlState.Idle;

    }
    private void Start()
    {
        nextLocation = 0;

    }
    protected override void Update()
    {
        Move();
        UpdateAnimaion();
        DestroyByTime(timeDuration, gameObject);
    }
    private void Move()
    {
        state = girlState.Walk;
        anim.speed = moveSpeed;
        transform.position = Vector3.MoveTowards(
            transform.position,
            location[nextLocation].transform.position,
            0
        );
        if (Vector3.Distance(transform.position, location[nextLocation].transform.position) <= 0.1f)
        {
            nextLocation++;
            if (nextLocation >= location.Length)
            {
                gameObject.SetActive(false);
            }
        }
        
    }
    protected override void UpdateAnimaion()
    {
        base.UpdateAnimaion();
    }

    protected override void DestroyByTime(float time, GameObject jumpscare)
    {
        base.DestroyByTime(time, jumpscare);
    }
}
