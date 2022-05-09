using UniRx;
using UnityEngine;

namespace Abstractions
{
    public interface IUnitProducer
    {
        IReadOnlyReactiveCollection<IUnitProductionTask> Queue { get; }
        public void SetDepotPoint(Vector3 point);
        public void Cancel(int index);
    }
}