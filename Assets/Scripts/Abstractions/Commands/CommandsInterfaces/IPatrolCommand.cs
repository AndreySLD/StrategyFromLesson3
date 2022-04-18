using UnityEngine;

namespace Abstractions.Commands.CommandsInterfaces
{
    public interface IPatrolCommand : ICommand
    {
        //public Vector3 StartPosition { get; }
        public Vector3 FinishPosition { get; }
    }
}