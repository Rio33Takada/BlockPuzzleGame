using UnityEngine;

public class UIActionButton : MonoBehaviour
{
    [SerializeField] private GameUIAction action;

    public virtual void OnClick()
    {

    }

    protected virtual void ButtonAction()
    {
        Debug.Log("UIActionButtonClicked");
    }
}
