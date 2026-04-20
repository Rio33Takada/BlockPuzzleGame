using UnityEngine;

public class PieceUIButton : StateLimitedButton
{
    public Piece Piece { get; private set; }

    protected override void ButtonAction()
    {
        Debug.Log("PieceUIButton");
    }
}
