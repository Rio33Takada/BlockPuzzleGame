using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StartPlayerTurn", menuName = "Data/State/StartPlayerTurn")]

public class StartPlayerTurn : TransitionHasNoConditionState
{
    public override void Enter(BattleContext context)
    {
        base.Enter(context);
        Debug.Log("StartPlayerTurn");

        // ピース配列決定.
        var pieceList = CreatePieceList(context);

        // 盤面の状態を取得.
        var board = context.BoardGrid.Grid;

        // リセット内容クラスを作成.
        var snapShot = new BoardStateSnapshot(board, pieceList);
        context.SetBoardStateSnapshot(snapShot);

        // ピースUI生成.
        context.UIController.CreatePieceUIList();

    }

    private List<Piece> CreatePieceList(BattleContext context)
    {
        var pieceList = new List<Piece>();
        foreach(var c in context.PlayerTeam)
        {
            foreach (var p in c.Data.OwnPieces)
            {
                var piece = new Piece(c, p.cellOffsets);

                pieceList.Add(piece);
            }
        }
        return pieceList;
    }
}
