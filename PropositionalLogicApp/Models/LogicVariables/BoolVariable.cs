using System;

namespace PropositionalLogicApp.Models.LogicVariables
{
    public class BoolVariable : ILogicVariable
    {
        private bool _value = false;

        public object Value
        {
            get => _value;
            set
            {
                if(value is bool boolValue)
                {
                    _value = boolValue;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Type Type => typeof(bool);

        public string Name => "Bool";

        public bool Bool => _value;
    }
}