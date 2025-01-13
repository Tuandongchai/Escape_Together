using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public EnemyState enemyState;
    public void Initialize(EnemyState currentState)
    {
        enemyState = currentState;
        enemyState.Enter();
    }
    public void ChangeState(EnemyState newState)
    {
        enemyState.Exis();
        enemyState = newState;
        enemyState.Enter();
    }
}
