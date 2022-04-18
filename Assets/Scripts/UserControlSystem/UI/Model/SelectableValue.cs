using System;
using Abstractions;
using UnityEngine;
using UserControlSystem.UI.Model;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
    public class SelectableValue : ScriptableObjectValueBase<ISelectable>
    {
        
    }
}