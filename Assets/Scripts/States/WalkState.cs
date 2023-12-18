using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : GroundedState
{
    private PlayerController player;
    private PlayerStateMachine sm;

    public WalkState(PlayerController player, PlayerStateMachine sm) : base(player, sm)
    {
        this.player = player;
        this.sm = sm;
    }
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Walk");
        player.spriteRenderer.color = Color.red;
    }

    public override void Update()
    {
        base.Update();
        if (Mathf.Abs(player.movement.x) < Mathf.Epsilon) sm.TransitionTo(sm.idleState);
    }
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        player.rgbd.velocity = new Vector2(player.movement.x * player.speed, player.rgbd.velocity.y);
    }

    public override void Exit()
    {

    }
}
