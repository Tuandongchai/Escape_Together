using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public FixedJoystick joystick;
    public float SpeedMove;
    private CharacterController controller;
    [SerializeField] private Animator[] anim;
    [SerializeField] private float xVelocity;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        Vector3 move = transform.right * joystick.Horizontal + transform.forward * joystick.Vertical;
        PlayerMove(move);
        UpdateAnimation(move);
    }
    private void PlayerMove(Vector3 move)
    {
        controller.Move(move *SpeedMove * Time.deltaTime);
    }
    private void UpdateAnimation(Vector3 move)
    {
        
        xVelocity = Mathf.Sqrt(Mathf.Pow(move.x, 2)+ Mathf.Pow(move.y,2) + Mathf.Pow(move.z,2));
        if (xVelocity==0)
        {
            for (int i=0; i<anim.Length; i++)
            {
                anim[i].SetBool("Idle", true);
                anim[i].SetBool("Move", false);

            }
        }
        else
        {
            for (int i=0; i<anim.Length; i++)
            {
                anim[i].SetBool("Idle", false);
                anim[i].SetBool("Move", true);
                anim[i].SetFloat("xVelocity", xVelocity);

            }
        }
    }
}
