using UnityEngine;

public class BattleEnemyFactory
{
    private readonly EnemyDatabase database;

    public BattleEnemyFactory(EnemyDatabase database)
    {
        this.database = database;
    }

    public BattleEnemy CreateEnemy(int id)
    {
        var data = database.GetEnemyData(id);
        var enemy = new BattleEnemy(data);
        return enemy;
    }
}
