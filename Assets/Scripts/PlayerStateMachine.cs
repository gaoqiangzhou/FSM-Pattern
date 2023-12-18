using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public WalkState walkState;
    public IdleState idleState;
    public JumpState jumpState;

    public PlayerStateMachine(PlayerController player)
    {
        this.walkState = new WalkState(player, this);
        this.idleState = new IdleState(player, this);
        this.jumpState = new JumpState(player, this);
    }
}
