using Abstractions;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public class AttackComand : IAttackCommand  
    {
        public IAttackable Target { get; }

        public AttackComand(IAttackable target)
        {
            Target = target;
        }
    }
}