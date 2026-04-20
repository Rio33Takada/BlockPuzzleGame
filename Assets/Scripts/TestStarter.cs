using UnityEngine;

public class TestStarter : MonoBehaviour
{
    public ObjectController objController;
    public UIController uiController;

    public StageData stageData;
    public PlayerData playerData;
    public CharaDatabase charaDatabase;
    public EnemyDatabase enemyDatabase;
    public GameStateBase startState;

    void Start()
    {
        var context = new BattleContext(stageData, objController, uiController);
        var stateMachine = new GameStateMachine(context);
        context.SetStateMachine(stateMachine);
        var battleInitializer = new BattleInitializer
            (
            objController,
            uiController,
            stageData,
            charaDatabase,
            enemyDatabase,
            playerData,
            context
            );
        uiController.SetStateMachine(stateMachine);
        stateMachine.Initialize(startState);
    }
}
