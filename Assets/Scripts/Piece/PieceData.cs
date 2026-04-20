using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "PieceData", menuName = "Data/PieceData")]

public class PieceData : ScriptableObject
{
    public GameObject piecePrefab;

    public List<Vector2Int> cellOffsets;


}
