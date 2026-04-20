using UnityEngine;
using System.Collections.Generic;

public class StateLimitedButton : UIActionButton
{
    [SerializeField] protected List<GameStateBase> enableState;

    public GameStateMachine StateMachine { get; private set; }

    public void SetStateMachine(GameStateMachine stateMachine)
    {
        this.StateMachine = stateMachine;
    }

    public override void OnClick()
    {
        if (enableState.Contains(StateMachine.CurrentState))
        {
            ButtonAction();
            base.OnClick();
        }
    }

    protected override void ButtonAction()
    {
        Debug.Log("StateLimitedButton");
    }
}
