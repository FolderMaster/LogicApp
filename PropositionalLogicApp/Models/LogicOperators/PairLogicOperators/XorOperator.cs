namespace PropositionalLogicApp.Models.LogicOperators.PairLogicOperators
{
    public class XorOperator : IPairLogicOperator
    {
        public ILogicValue LeftOperand { get; set; }

        public ILogicValue RightOperand { get; set; }

        public string Char => "XOR";

        public bool Bool => LeftOperand.Bool ^ RightOperand.Bool;
    }
}