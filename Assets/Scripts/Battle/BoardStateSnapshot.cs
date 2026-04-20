using System.Collections.Generic;
using UnityEngine;

public class BoardStateSnapshot
{
    public BoardCell[,] Grid { get; private set; }
    public List<Piece> Pieces { get; private set; }

    public BoardStateSnapshot(BoardCell[,] grid, List<Piece> pieces)
    {
        this.Grid = grid;
        this.Pieces = pieces;
    }
}
