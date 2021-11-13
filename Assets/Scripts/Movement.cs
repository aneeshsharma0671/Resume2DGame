using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public static Movement instance;
    public CharacterController2D controller;
    private float horizontalMove;
    public float Speed;
    public float move;
    public bool jump;
    public bool ActionIsPressed;

    public bool canMove = false;
    public bool canJump;

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
        }else
        {
            instance = this;
        }
    }
    void Update()
    {    
    }
    private void FixedUpdate()
    {
        if(canMove)
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;
        ActionIsPressed = false;
    }
    public void Move(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>().x;
        horizontalMove = move * Speed;
    }

    public void Jump()
    {
        if(canJump)
        jump = true;
    }

    public void Action(InputAction.CallbackContext context)
    {
        if(context.started)
            ActionIsPressed = true;
        if(context.performed)
            ActionIsPressed = true;
        if (context.canceled)
            ActionIsPressed = false;
        else
            ActionIsPressed = true;
    }
  
}
