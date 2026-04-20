using System.Collections.Generic;
using UnityEngine;

public class BattleEnemy
{
    public EnemyData Data { get; private set; }

    public int PosX { get; private set; }
    public int PosY { get; private set; }

    public float CurrentHp {  get; private set; }
    public float MaxHp { get; private set; }
    public float BaseAttack { get; private set; }

    public List<PieceDamageEntry> DamageEntries { get; private set; }

    public List<EnemyBodyCell> BodyCells { get; private set; }

    public BattleEnemy(EnemyData data, int posX, int posY)
    {
        this.Data = data;
        MaxHp = data.hp;
        BaseAttack = data.attack;
        CreateBodyCells();
        PosX = posX;
        PosY = posY;
    }

    private void CreateBodyCells()
    {
        BodyCells = new List<EnemyBodyCell>();
        foreach(var offset in Data.cellOffsets)
        {
            var cell = new EnemyBodyCell(this, offset.x, offset.y);
            BodyCells.Add(cell);
        }
    }

    public void AddDamageEntry(PieceDamageEntry entry)
    {
        DamageEntries.Add(entry);
    }

    public IEnumerable<Vector2Int> GetBodyPositions()
    {
        foreach(var cell in BodyCells)
        {
            yield return new Vector2Int(PosX + cell.OffsetX, PosY + cell.OffsetY);
        }
    }
}
