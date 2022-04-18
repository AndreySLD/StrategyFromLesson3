using System;
using UnityEngine;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(TargetableValue), menuName = "Strategy Game/" + nameof(TargetableValue), order = 0)]
    public sealed class TargetableValue : CommandValue<GameObject>
    { 
        
    }
}
