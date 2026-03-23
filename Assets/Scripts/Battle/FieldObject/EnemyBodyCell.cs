using UnityEngine;

public class EnemyBodyCell : IFieldObject
{
    private readonly BattleEnemy parentEnemy;

    public int OffsetX { get; private set; }
    public int OffsetY { get; private set; }

    public EnemyBodyCell(BattleEnemy parentEnemy, int offsetX, int offsetY)
    {
        this.parentEnemy = parentEnemy;
        OffsetX = offsetX;
        OffsetY = offsetY;
    }

    public void HitPiece(Piece piece, float damage)
    {
        parentEnemy.AddDamageEntry(new PieceDamageEntry(piece, damage));
    }
}
