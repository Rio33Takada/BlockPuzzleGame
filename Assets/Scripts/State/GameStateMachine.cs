using UnityEngine;

public class GameStateMachine
{
    public event System.Action<GameStateBase> OnStateChanged;
    public GameStateBase CurrentState { get; private set; }

    private readonly BattleContext context;

    public GameStateMachine(BattleContext context)
    {
        this.context = context;
    }

    public void Initialize(GameStateBase startState)
    {
        CurrentState = startState;
        CurrentState.Enter(context);
    }

    public void ChangeState(GameStateBase newState)
    {
        if(CurrentState !=  null) CurrentState.Exit();
        else Debug.Log("CurrentState is null");

        CurrentState = newState;

        if(CurrentState != null) CurrentState.Enter(context);

        OnStateChanged?.Invoke(CurrentState);
    }
}
