public interface IGameState
{
    void Enter(BattleContext context);
    void Update();
    void Exit();
}
