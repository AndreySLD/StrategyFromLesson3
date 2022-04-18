using System;
using UnityEngine;
using UserControlSystem.UI.Model;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(Vector3Value), menuName = "Strategy Game/" + nameof(Vector3Value), order = 0)]
    public sealed class Vector3Value : ScriptableObjectValueBase<Vector3>
    { 
        
    }
}