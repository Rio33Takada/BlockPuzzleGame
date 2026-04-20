using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "CharaData", menuName = "Data/CharaData")]

public class CharaData : ScriptableObject
{
    public int id;
    public string charaName;
    public Sprite iconImage;
    public float hp;
    public float attack;
    public List<PieceData> OwnPieces;
}
