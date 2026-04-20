using UnityEngine;
using System.Collections.Generic;

public class BattleContext
{
    public int RandomSeed { get; private set; }
    public GameStateMachine StateMachine { get; private set; }
    public ObjectController ObjectController { get; private set; }
    public UIController UIController { get; private set; }
    public StageData StageData { get; private set; }
    public BattleCharaFactory CharaFactory { get; private set; }
    public BattleEnemyFactory EnemyFactory { get; private set; }
    public BoardGrid BoardGrid { get; private set; }
    public FieldGrid FieldGrid { get; private set; }
    public List<BattleEnemy> BattleEnemies { get; private set; }
    public List<BattleChara> PlayerTeam {  get; private set; }
    public BoardStateSnapshot BoardStateSnapshot { get; private set; }

    public BattleContext(
        StageData stageData,
        ObjectController objectController,
        UIController uIController
        )
    {
        this.StageData = stageData;
        BattleEnemies = new List<BattleEnemy>();
        PlayerTeam = new List<BattleChara>();
        ObjectController = objectController;
        UIController = uIController;
    }

    public void SetRandomSeed(int seed)
    {
        this.RandomSeed = seed;
    }

    public void SetStateMachine(GameStateMachine stateMachine)
    {
        this.StateMachine = stateMachine;
    }

    public void SetCharaFactory(BattleCharaFactory charaFactory)
    {
        this.CharaFactory = charaFactory;
    }

    public void SetEnemyFactory(BattleEnemyFactory enemyFactory)
    {
        this.EnemyFactory = enemyFactory;
    }

    public void SetBoardGrid(BoardGrid boardGrid)
    {
        this.BoardGrid = boardGrid;
    }

    public void SetFieldGrid(FieldGrid fieldGrid)
    {
        this.FieldGrid = fieldGrid;
    }

    public void SetPlayerTeam(List<BattleChara> team)
    {
        this.PlayerTeam = team;
    }

    public void AddEnemy(BattleEnemy enemy)
    {
        BattleEnemies.Add(enemy);
    }

    public void SetBoardStateSnapshot(BoardStateSnapshot boardStateSnapshot)
    {
        this.BoardStateSnapshot = boardStateSnapshot;
    }
}
