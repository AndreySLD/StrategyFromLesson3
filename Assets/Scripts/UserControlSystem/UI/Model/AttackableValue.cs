using System;
using UnityEngine;
using UserControlSystem.UI.Model;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(AttackableValue), menuName = "Strategy Game/" + nameof(AttackableValue), order = 0)]
    public sealed class AttackableValue : ScriptableObjectValueBase<IAttackable>
    {
        
    }
}