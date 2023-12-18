using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public void Enter()
    {
        //code that runs when first enter the state
    }

    public void Update()
    {
        //per-frame logic, include condition to transition to a new state
    }
    public void FixedUpdate()
    {
        //fixed time interval update
    }
    public void Exit()
    {
        //code that runs when exit the 
    }
}