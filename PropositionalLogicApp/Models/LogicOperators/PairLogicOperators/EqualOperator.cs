namespace PropositionalLogicApp.Models.LogicOperators.PairLogicOperators
{
    public class EqualOperator : IPairLogicOperator
    {
        public ILogicValue LeftOperand { get; set; }

        public ILogicValue RightOperand { get; set; }

        public string Char => "EQUAL";

        public bool Bool => LeftOperand.Bool == RightOperand.Bool;
    }
}