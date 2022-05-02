using Abstractions.Commands.CommandsInterfaces;
using System;
using UnityEngine;
using UserControlSystem.CommandsRealization;

namespace UserControlSystem
{
    public class SetDepotPointCommandCommandCreator : CancellableCommandCreatorBase<ISetDepotPointCommand, Vector3>
    {
        protected override ISetDepotPointCommand CreateCommand(Vector3 argument) => new SetDepotPointCommand(argument);
    }
}