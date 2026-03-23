using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "EnemyDatabase", menuName = "Data/Database/EnemyDatabase")]

public class EnemyDatabase : ScriptableObject
{
    public List<EnemyDataEntry> database;

    public EnemyData GetEnemyData(int id)
    {
        foreach(var entry in database)
        {
            if (entry.id == id) return entry.data;
        }
        return null;
    }
}
