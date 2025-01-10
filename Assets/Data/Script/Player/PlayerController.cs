using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public FixedJoystick joystick;
    public float SpeedMove;
    private CharacterController controllere;

    private void Start()
    {
        controllere = GetComponent<CharacterController>();
    }
    private void Update()
    {
        Vector3 Move = transform.right * joystick.Horizontal + transform.forward * joystick.Vertical;
        controllere.Move(Move *SpeedMove * Time.deltaTime);
    }
}
