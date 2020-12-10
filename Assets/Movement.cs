using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;
    private float horizontalMove;
    private Vector3 position;
    private float width;
    private float height;
    public float Speed;

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
        if(Input.GetKey("c"))
        {
            horizontalMove = 1f*Speed;
        }
        if (Input.GetKey("z"))
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
            
        }
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false,false);
        horizontalMove = 0f;
    }
  
}
