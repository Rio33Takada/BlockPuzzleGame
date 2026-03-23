using UnityEngine;

public class BoardGrid
{
    public int Width { get; private set; }
    public int Height { get; private set; }

    public BoardCell[,] Grid { get; private set; }

    public BoardGrid(StageData data)
    {
        Width = data.width;
        Height = data.height;

        Grid = new BoardCell[Width, Height];

        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                Grid[x, y] = new BoardCell(x, y);
            }
        }
    }
}
