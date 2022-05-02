using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public sealed class SetDepotPointCommand : ISetDepotPointCommand
    {
        public Vector3 Point { get; }
        
        public SetDepotPointCommand(Vector3 point)
        {
            Point = point;
        }
    }
}
