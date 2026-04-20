using UnityEngine;

public abstract class GameStateBase : ScriptableObject, IGameState
{
    protected BattleContext context;

    public virtual void Enter(BattleContext context)
    {
        this.context = context;
    }
    public virtual void Update() { }
    public virtual void Exit() { }
}
