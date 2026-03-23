using UnityEngine;
using System.Collections.Generic;

public class BattleContext
{
    public BoardGrid BoardGrid { get; private set; }
    public FieldGrid FieldGrid { get; private set; }
    public List<BattleEnemy> BattleEnemies { get; private set; }
    public List<BattleChara> PlayerTeam {  get; private set; }

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
}
