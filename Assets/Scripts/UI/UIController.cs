using UnityEngine;
using System.Collections.Generic;

public class UIController : MonoBehaviour
{
    [SerializeField] private CharaUIPanel charaUIPanelPrefab;
    [SerializeField] private Transform charaUIPanelParent;

    public List<CharaUIPanel> CharaUIPanels {  get; private set; }

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
}
