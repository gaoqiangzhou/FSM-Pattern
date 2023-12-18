using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine
{
    public IState CurrentState { get; private set; }

    public void Initialize(IState startingState)
    {
        CurrentState = startingState;
        startingState.Enter();
    }

    public void TransitionTo(IState nextState)
    {
        CurrentState.Exit();
        CurrentState = nextState;
        nextState.Enter();
    }
    public void Update()
    {
        CurrentState?.Update();
    }
    public void FixedUpdate()
    {
        CurrentState?.FixedUpdate();
    }
}
