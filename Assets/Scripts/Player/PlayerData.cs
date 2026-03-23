using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/PlayerData")]

public class PlayerData : ScriptableObject
{
    public List<int> playerTeam;
}
