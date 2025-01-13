using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    protected Enemy enemy;
    protected EnemyStateMachine stateMachine;
    protected string boolName;
    public EnemyState(Enemy _enemy, EnemyStateMachine _stateMachine, string _boolName)
    {
        this.enemy = _enemy;
        this.stateMachine = _stateMachine;
        this.boolName = _boolName;
    }
    public void Enter()
    {
        enemy.anim.SetBool(boolName, true);
    }
    public void Exis()
    {
        enemy.anim.SetBool(boolName, false);
    }
}
