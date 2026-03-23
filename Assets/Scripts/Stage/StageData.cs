using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "StageData", menuName = "Data/StageData")]

public class StageData : ScriptableObject
{
    public int width;
    public int height;

    public List<EnemySpawnEntry> enemySpawnEntries;
}
