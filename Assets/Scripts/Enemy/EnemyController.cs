using UnityEngine;

public class EnemyController
{
    private readonly FieldGrid grid;
    private readonly BattleEnemyFactory factory;

    public EnemyController(FieldGrid grid, BattleEnemyFactory factory)
    {
        this.grid = grid;
        this.factory = factory;
    }

    public BattleEnemy Spawn(EnemySpawnEntry entry)
    {
        var enemy = factory.CreateEnemy(entry.id);
        //enemy.Data;

        return enemy;
    }
}
