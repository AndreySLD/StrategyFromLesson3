﻿using UnityEngine;

namespace Abstractions.Commands.CommandsInterfaces
{
    public interface IProduceGrenadierCommand : ICommand, IIconHolder
    {
        float ProductionTime { get; }
        GameObject UnitPrefab { get; }
        string UnitName { get; }
    }
}