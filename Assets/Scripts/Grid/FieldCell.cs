public class FieldCell
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public IFieldObject Occupant { get; private set; }

    public bool IsOccupied => Occupant != null;

    public FieldCell(int x, int y)
    {
        X = x;
        Y = y;
        Occupant = null;
    }

    public void SetOccupant(IFieldObject newOccupant)
    {
        Occupant = newOccupant;
    }
}
