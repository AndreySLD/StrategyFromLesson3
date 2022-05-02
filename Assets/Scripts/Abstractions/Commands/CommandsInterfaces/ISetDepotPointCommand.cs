using UnityEngine;

namespace Abstractions.Commands.CommandsInterfaces
{
    public interface ISetDepotPointCommand : ICommand
    {
        public Vector3 Point { get; }
    }
}
