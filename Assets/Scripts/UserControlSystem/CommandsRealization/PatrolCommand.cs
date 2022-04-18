using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public class PatrolCommand : IPatrolCommand
    {
        //public Vector3 StartPosition { get; }
        public Vector3 FinishPosition { get; }

        public PatrolCommand(Vector3 finish)
        {
            //StartPosition = start;
            FinishPosition = finish;
        }
    }
}