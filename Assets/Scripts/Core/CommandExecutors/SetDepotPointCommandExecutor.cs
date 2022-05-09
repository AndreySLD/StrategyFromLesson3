using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using Core.CommandExecutors;
using System.Threading.Tasks;
using UnityEngine;

namespace Core.CommandExecutors
{
    public class SetDepotPointCommandExecutor : CommandExecutorBase<ISetDepotPointCommand>
    {
        public override async Task ExecuteSpecificCommand(ISetDepotPointCommand command)
        {
            var produceCommandExecutor = GetComponent<IUnitProducer>();
            produceCommandExecutor.SetDepotPoint(command.Point);
            Debug.Log($"{command.Point} is set as position for units!");
            await Task.CompletedTask;
        }
    }
}