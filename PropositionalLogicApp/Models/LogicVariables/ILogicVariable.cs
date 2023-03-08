using System;

namespace PropositionalLogicApp.Models.LogicVariables
{
    public interface ILogicVariable : ILogicValue
    {
        string Name { get; set; }

        string TypeName { get; }
    }
}