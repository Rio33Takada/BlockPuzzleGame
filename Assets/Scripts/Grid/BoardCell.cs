public class BoardCell
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public IBoardObject Occupant { get; private set; }

    public bool IsOccupied => Occupant != null;

    public BoardCell(int x, int y)
    {
        X = x;
        Y = y;
    }
}
