using System;

namespace PropositionalLogicApp.Models.LogicVariables
{
    public interface ILogicVariable : ILogicValue
    {
        object Value { get; set; }

        Type Type { get; }

        string Name { get; }
    }
}