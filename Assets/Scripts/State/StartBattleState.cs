using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StartBattleState", menuName = "Data/State/StartBattleState")]

public class StartBattleState : TransitionHasNoConditionState
{
    public override void Enter(BattleContext context)
    {
        base.Enter(context);
        Debug.Log("StartBattleState");

        // 乱数シード値設定.
        context.SetRandomSeed(0);

        // 敵スポーン.
        SpawnEneny(context);

        context.StateMachine.ChangeState(nextState);
    }

    private void SpawnEneny(BattleContext context)
    {
        foreach (var enemy in SpawnEnemies(context))
        {
            context.AddEnemy(enemy);
            // 敵見た目生成.
            context.ObjectController.CreateEnemy(enemy);
        }
    }

    List<BattleEnemy> SpawnEnemies(BattleContext context)
    {
        var data = context.StageData;
        var factory = context.EnemyFactory;
        var enemies = new List<BattleEnemy>();
        foreach (var entry in data.enemySpawnEntries)
        {
            // データ生成.
            var enemy = factory.CreateEnemy(entry);

            // 配置可能ならリストに追加.
            if (context.FieldGrid.CanPlaceObject(enemy.GetBodyPositions()))
            {
                enemies.Add(enemy);
            }
        }

        return enemies;
    }
}
