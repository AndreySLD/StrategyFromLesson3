using UnityEngine;

namespace Abstractions
{
    public interface ISelectable : IHealth
    {
        Sprite Icon { get; }
    }
}