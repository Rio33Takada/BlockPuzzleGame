using UnityEngine;
using System.Collections.Generic;

public class HasTransitionState : GameStateBase
{
    [SerializeField] protected List<UIActionTransition> transitions;
}
