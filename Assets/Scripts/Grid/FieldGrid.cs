using System.Collections.Generic;
using UnityEngine;

public class FieldGrid
{
    private readonly float cellSize = 1;
    public float CellSize => cellSize;
    public int Width { get; private set; }
    public int Height { get; private set; }

    public FieldCell[,] Grid { get; private set; }

    public FieldGrid(StageData data)
    {
        Width = data.width;
        Height = data.height;

        Grid = new FieldCell[Width, Height];

        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                Grid[x, y] = new FieldCell(x, y);
            }
        }
    }

    public FieldCell GetCell(int x, int y)
    {
        if (x < 0 || x >= Width || y < 0 || y >= Height)
        {
            return null;
        }

        return Grid[x, y];
    }

    public bool CanPlaceObject(IEnumerable<Vector2Int> positions)
    {
        foreach(var pos in positions)
        {
            var cell = GetCell(pos.x, pos.y);
            if (cell == null) return false;

            if(cell.IsOccupied) return false;
        }
        return true;
    }
}
