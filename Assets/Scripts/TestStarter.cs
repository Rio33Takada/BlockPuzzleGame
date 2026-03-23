using UnityEngine;

public class TestStarter : MonoBehaviour
{
    public UIController uiController;

    public StageData stageData;
    public PlayerData playerData;
    public CharaDatabase charaDatabase;
    public EnemyDatabase enemyDatabase;

    void Start()
    {
        var context = new BattleContext();
        var battleInitializer = new BattleInitializer
            (
            uiController,
            stageData,
            charaDatabase,
            enemyDatabase,
            playerData,
            context
            );
    }
}
