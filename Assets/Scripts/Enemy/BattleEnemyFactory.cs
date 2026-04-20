using UnityEngine;

public class BattleEnemyFactory
{
    private readonly EnemyDatabase database;

    public BattleEnemyFactory(EnemyDatabase database)
    {
        this.database = database;
    }

    public BattleEnemy CreateEnemy(EnemySpawnEntry entry)
    {
        var data = database.GetEnemyData(entry.id);
        var enemy = new BattleEnemy(data, entry.pozX, entry.pozY);
        return enemy;
    }
}
