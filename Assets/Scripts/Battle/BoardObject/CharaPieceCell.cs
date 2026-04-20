using UnityEngine;

public class CharaPieceCell : IBoardObject
{
    private readonly Piece parentPiece;

    public int OffsetX { get; private set; }
    public int OffsetY { get; private set; }

    public CharaPieceCell(Piece parentPiece, int offsetX, int offsetY)
    {
        this.parentPiece = parentPiece;
        OffsetX = offsetX;
        OffsetY = offsetY;
    }
}
