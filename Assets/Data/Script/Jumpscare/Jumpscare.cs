using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    protected float timeStart;


    protected virtual void OnTriggerEnter(Collider other)
    {
        timeStart = Time.time;
        if (other.gameObject.CompareTag("Player"))
        {
            
        }
    }
    protected virtual void Update()
    {

    }
    protected virtual void Whatwillhappen()
    {
    }
    protected virtual void DestroyByTime(float time, GameObject jumpscare)
    {
        float timeDuration = Time.time - timeStart;
        if(timeDuration>=time ){ 
            jumpscare.SetActive(false);
        }
    }
    protected virtual void DetroyByDistance(float distanceDestroy, GameObject jumpscare, GameObject player)
    {
        float distance = Vector3.Distance(jumpscare.transform.position, player.transform.position);
        if (distance == distanceDestroy)
        {
            jumpscare.SetActive(false);
        }
    }

    
}
