namespace PropositionalLogicApp.Models.LogicOperators.SimpleLogicOperators
{
    public class NotOperator : ISimpleLogicOperator
    {
        public ILogicValue Operand { get; set; }

        public string Char => "NOT";

        public bool Bool => !Operand.Bool;

        public override string ToString() => $"!{Operand}";
    }
}