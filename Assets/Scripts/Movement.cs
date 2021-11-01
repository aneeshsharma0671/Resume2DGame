using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;
    private float horizontalMove;
    public float Speed;
    public float move;
    public bool jump;

    private void Awake()
    {
    }
    void Update()
    {    
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;
       // horizontalMove = 0f;
    }
    public void Move(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>().x;
        horizontalMove = move * Speed;
    }

    public void Jump()
    {
        jump = true;
    }
  
}
