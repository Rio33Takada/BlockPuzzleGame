using UnityEngine;
using UnityEngine.UI;

public class CharaUIPanel : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Text nameText;
    public void SetData(BattleChara chara)
    {
        var data = chara.Data;
        nameText.text = data.name;
        icon.sprite = data.iconImage;
    }
}
