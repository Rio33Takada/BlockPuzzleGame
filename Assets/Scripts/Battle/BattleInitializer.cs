using System.Collections.Generic;
using UnityEngine;

public class BattleInitializer
{

    public BattleInitializer
        (
        UIController uiController,
        StageData stageData,
        CharaDatabase charaDatabase,
        EnemyDatabase enemyDatabase,
        PlayerData playerData,
        BattleContext context
        )
    {
        // グリッドデータ生成.
        context.SetFieldGrid(CreateFieldGrid(stageData));
        context.SetBoardGrid(CreateBoardGrid(stageData));

        // キャラデータ生成.
        var charaFactory = new BattleCharaFactory(charaDatabase);
        context.SetPlayerTeam(CreateTeamChara(playerData, charaFactory));

        // キャラUIパネル生成.
        uiController.CreateCharaUIPanel(context.PlayerTeam);

        // 敵データ生成.
        var enemyFactory = new BattleEnemyFactory(enemyDatabase);

        // 敵スポーン(この処理はもう少しあとに回すべき).
        foreach(var enemy in SpawnEnemies(context, stageData, enemyFactory))
        {
            context.AddEnemy(enemy);
        }
    }

    FieldGrid CreateFieldGrid(StageData data)
    {
        return new FieldGrid(data);
    }

    BoardGrid CreateBoardGrid(StageData data)
    {
        return new BoardGrid(data);
    }

    List<BattleChara> CreateTeamChara(PlayerData data, BattleCharaFactory factory)
    {
        var team = new List<BattleChara>();
        foreach(var charaId in data.playerTeam)
        {
            var chara = factory.CreateChara(charaId);
            team.Add(chara);
        }

        return team;
    }

    List<BattleEnemy> SpawnEnemies(BattleContext context, StageData data, BattleEnemyFactory factory)
    {
        var enemies = new List<BattleEnemy>();
        foreach(var entry in data.enemySpawnEntries)
        {
            var enemy = factory.CreateEnemy(entry.id);
            foreach(var pos in enemy.GetBodyPositions(entry.pozX, entry.pozY))
            {
                if(context.FieldGrid.GetCell(pos.x, pos.y).IsOccupied)
                {
                    break;
                }
                enemies.Add(enemy);
            }
        }

        return enemies;
    }
}
