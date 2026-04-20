using UnityEngine;
using System.Collections.Generic;

public class UIController : MonoBehaviour
{
    public GameStateMachine StateMachine { get; private set; }
    [SerializeField] private CharaUIPanel charaUIPanelPrefab;
    [SerializeField] private Transform charaUIPanelParent;
    [SerializeField] private GameObject pieceUIPrefab;

    private BattleContext context;

    public List<CharaUIPanel> CharaUIPanels { get; private set; }

    public void SetData(BattleContext context)
    {
        this.context = context;
    }

    public void SetStateMachine(GameStateMachine stateMachine)
    {
        this.StateMachine = stateMachine;
    }

    public void CreateCharaUIPanel(List<BattleChara> team)
    {
        CharaUIPanels = new List<CharaUIPanel>();
        foreach(var chara in team)
        {
            var panel = Instantiate(charaUIPanelPrefab, charaUIPanelParent);
            CharaUIPanels.Add(panel);
            panel.SetData(chara);
        }
    }

    public void CreatePieceUIList()
    {
        var list = new List<GameObject>();
        foreach (var piece in context.BoardStateSnapshot.Pieces)
        {
            var obj = CreatePieceUI(piece);
            list.Add(obj);
        }
    }

    private GameObject CreatePieceUI(Piece piece)
    {
        var obj = Instantiate(pieceUIPrefab);
        obj.GetComponent<StateLimitedButton>().SetStateMachine(StateMachine);
        return obj;
    }
}
