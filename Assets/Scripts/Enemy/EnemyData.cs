using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Data/EnemyData")]

public class EnemyData : ScriptableObject
{
    public int id;
    public string enemyName;
    public float hp;
    public float attack;

    public GameObject enemyPrefab;
}
