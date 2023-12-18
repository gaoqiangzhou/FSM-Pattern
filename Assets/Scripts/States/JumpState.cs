using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : IState
{
    private PlayerController player;
    private PlayerStateMachine sm;
    private bool grounded;
    private int groundLayer = 1 << 6; //6th layer

    public JumpState(PlayerController player, PlayerStateMachine sm)
    {
        this.player = player;
        this.sm = sm;
    }
    public void Enter()
    {
        Debug.Log("Jump");
        player.spriteRenderer.color = Color.green;
        grounded = false;
        Vector2 vel = player.rgbd.velocity;
        vel.y += player.jumpForce;
        player.rgbd.velocity = vel;
    }

    public void Update()
    {
        if(grounded)
        {
            sm.TransitionTo(sm.idleState);
        }
    }
    public void FixedUpdate()
    {
        grounded = player.rgbd.velocity.y < Mathf.Epsilon && player.rgbd.IsTouchingLayers(groundLayer);
    }

    public void Exit()
    {

    }
}
