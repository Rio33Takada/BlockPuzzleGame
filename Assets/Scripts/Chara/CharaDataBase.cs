using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "CharaDatabase", menuName = "Data/Database/CharaDatabase")]

public class CharaDatabase : ScriptableObject
{
    public List<CharaDataEntry> database;

    public CharaData GetCharaData(int id)
    {
        foreach(var entry in database)
        {
            if (entry.id == id) return entry.data;
        }
        return null;
    }
}
