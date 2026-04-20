using System.Collections.Generic;
using UnityEngine;

public class Piece
{
    public GameObject PieceObject { get; private set; }
    private readonly BattleChara owner;

    public List<CharaPieceCell> cells;

    public int PosX { get; private set; }
    public int PosY { get; private set; }

    public Piece(BattleChara owner, List<Vector2Int> cellOffsets)
    {
        this.owner = owner;
        CreateCellList(cellOffsets);
    }

    private void CreateCellList(List<Vector2Int> offsets)
    {
        cells = new List<CharaPieceCell>();
        foreach (var offset in offsets)
        {
            var cell = new CharaPieceCell(this, offset.x, offset.y);
            cells.Add(cell);
        }
    }
}
