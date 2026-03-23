using UnityEngine;

public abstract class GameStateBase : ScriptableObject, IGameState
{
    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void Exit() { }
}
