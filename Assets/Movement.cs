using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;
    private float horizontalMove;
    private Vector3 position;
    private float width;
    private float height;
    public float Speed;
    public float move;
    public bool jump;

    public void Start()
    {
    }
    private void Awake()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;

    }
    void Update()
    {
    /*
        if(Input.GetKey("a"))
        {
            horizontalMove = 1f*Speed;
        }
        if (Input.GetKey("d"))
        {
            horizontalMove = -1f * Speed;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                pos.y = (pos.y - height) / height;
                position = new Vector3(pos.x, pos.y, 0.0f);
                if (position.x > 0.33f)
                {
                    horizontalMove = 1f * Speed;
                }
                if (position.x < -0.33f)
                {
                    horizontalMove = -1f * Speed;
                }
                if (position.x < 0.33f && position.x > -0.33f)
                {
                  
                }
            
        }*/
    
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false,jump);
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
