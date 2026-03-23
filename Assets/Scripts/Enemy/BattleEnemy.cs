using System.Collections.Generic;
using UnityEngine;

public class BattleEnemy
{
    public EnemyData Data { get; private set; }

    public float CurrentHp {  get; private set; }
    public float MaxHp { get; private set; }
    public float BaseAttack { get; private set; }

    public List<PieceDamageEntry> DamageEntries { get; private set; }

    public List<EnemyBodyCell> bodyCells { get; private set; }

    public BattleEnemy(EnemyData data)
    {
        this.Data = data;
        MaxHp = data.hp;
        BaseAttack = data.attack;
    }

    public void AddDamageEntry(PieceDamageEntry entry)
    {
        DamageEntries.Add(entry);
    }

    public IEnumerable<Vector2Int> GetBodyPositions(int originX, int originY)
    {
        foreach(var cell in bodyCells)
        {
            yield return new Vector2Int(originX + cell.OffsetX, originY + cell.OffsetY);
        }
    }
}
