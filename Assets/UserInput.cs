using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserInput : MonoBehaviour
{
    public static UserInput instance;
    public bool jumpPressed;
    public float moveInput;
    public bool InterectPressed;

    bool isReadyToClear;

    private void Awake()
    {
        if(instance == null)
        instance = this;
    }

    private void Update()
    {
        clearInput();
    }

    private void FixedUpdate()
    {
        isReadyToClear = true;
    }

    void clearInput()
    {
        if (!isReadyToClear)
            return;

        moveInput = 0f;
        jumpPressed = false;



        isReadyToClear = false;

    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>().x;
    }

    public void Jump()
    {
        jumpPressed = true;
    }

    public void InterectInput()
    {
        InterectPressed = true;
    }

}
