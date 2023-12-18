using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerStateMachine stateMachine;
    [HideInInspector]
    public Vector2 movement;
    public Rigidbody2D rgbd;
    public SpriteRenderer spriteRenderer;
    public float speed;
    public float jumpForce;
    void Awake()
    {
        //init
        stateMachine = new PlayerStateMachine(this);
        stateMachine.Initialize(stateMachine.idleState);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");//-1, 0, 1
        stateMachine.Update();
    }
    void FixedUpdate()
    {
        stateMachine.FixedUpdate();
    }
}
