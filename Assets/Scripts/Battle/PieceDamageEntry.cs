using UnityEngine;

public class PieceDamageEntry
{
    private readonly Piece piece;
    private readonly float damage;
    public PieceDamageEntry(Piece piece, float amount)
    {
        this.piece = piece;
        this.damage = amount;
    }
}
