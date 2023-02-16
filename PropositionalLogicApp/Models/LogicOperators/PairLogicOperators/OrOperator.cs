namespace PropositionalLogicApp.Models.LogicOperators.PairLogicOperators
{
    internal class OrOperator : IPairLogicOperator
    {
        public ILogicValue LeftOperand { get; set; }

        public ILogicValue RightOperand { get; set; }

        public string Char => "OR";

        public bool Bool => LeftOperand.Bool || RightOperand.Bool;
    }
}