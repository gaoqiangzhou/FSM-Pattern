using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedState : IState
{
    private PlayerController player;
    private PlayerStateMachine sm;

    public GroundedState(PlayerController player, PlayerStateMachine sm)
    {
        this.player = player;
        this.sm = sm;
    }
    public virtual void Enter()
    {
        
    }

    public virtual void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            sm.TransitionTo(sm.jumpState);
        }
    }
    public virtual void FixedUpdate()
    {
        
    }

    public virtual void Exit()
    {
        //Debug.Log("Exited Walk State");
    }
}
