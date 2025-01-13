using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlRombie_Cry : GirlRombieState
{
    [SerializeField] private float distance;
    [SerializeField] private float timeDuration;
    [SerializeField] private GameObject player;

    
    protected override void Update()
    {
        DestroyByTime(timeDuration, gameObject);
        DetroyByDistance(distance, gameObject, player);
        state = girlState.Idle;
    }

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }

   

    protected override void DestroyByTime(float time, GameObject jumpscare)
    {
        base.DestroyByTime(time, jumpscare);
    }

    protected override void DetroyByDistance(float distanceDestroy, GameObject jumpscare, GameObject player)
    {
        base.DetroyByDistance(distanceDestroy, jumpscare, player);
    }
}
