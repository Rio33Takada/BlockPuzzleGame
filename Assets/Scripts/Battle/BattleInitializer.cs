using System.Collections.Generic;
using UnityEngine;

public class BattleInitializer
{
    public BattleInitializer
        (
        ObjectController objController,
        UIController uiController,
        StageData stageData,
        CharaDatabase charaDatabase,
        EnemyDatabase enemyDatabase,
        PlayerData playerData,
        BattleContext context
        )
    {
        #region DataCreation
        // ファクトリ生成.
        var charaFactory = new BattleCharaFactory(charaDatabase);
        context.SetCharaFactory(charaFactory);
        var enemyFactory = new BattleEnemyFactory(enemyDatabase);
        context.SetEnemyFactory(enemyFactory);

        // グリッドデータ生成.
        context.SetFieldGrid(CreateFieldGrid(stageData));
        context.SetBoardGrid(CreateBoardGrid(stageData));

        // キャラデータ生成.
        context.SetPlayerTeam(CreateTeamChara(playerData, charaFactory));

        #endregion
        #region ViewGeneration
        // データ設定.
        objController.SetData(context);

        // グリッド見た目生成.
        foreach(var cell in context.FieldGrid.Grid)
        {
            objController.CreateFieldGirdCell(cell);
        }

        // キャラUIパネル生成.
        uiController.CreateCharaUIPanel(context.PlayerTeam);
        #endregion
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
}
