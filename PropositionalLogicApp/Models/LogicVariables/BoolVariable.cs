using System;

namespace PropositionalLogicApp.Models.LogicVariables
{
    public class BoolVariable : ILogicVariable
    {
        private string _name;

        private bool _value = false;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string TypeName => "Bool";

        public bool Value
        {
            get => _value;
            set => _value = value;
        }

        public bool Bool => _value;

        public override string ToString() => Name;
    }
}