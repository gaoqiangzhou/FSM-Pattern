using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : GroundedState
{
    private PlayerController player;
    private PlayerStateMachine sm;

    public IdleState(PlayerController player, PlayerStateMachine sm) : base(player, sm)
    {
        this.player = player;
        this.sm = sm;
    }
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Idle");
        player.spriteRenderer.color = Color.black;
    }

    public override void Update()
    {
        base.Update();
        if (player.movement != Vector2.zero)
        {
            sm.TransitionTo(sm.walkState);
        }
    }
    public override void FixedUpdate()
    {
        base .FixedUpdate();
        //fixed time interval update
    }

    public override void Exit()
    {

    }
}
