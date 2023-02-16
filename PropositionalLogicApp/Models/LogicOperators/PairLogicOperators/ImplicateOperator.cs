namespace PropositionalLogicApp.Models.LogicOperators.PairLogicOperators
{
    public class ImplicateOperator : IPairLogicOperator
    {
        public ILogicValue LeftOperand { get; set; }

        public ILogicValue RightOperand { get; set; }

        public string Char => "IMPLICATE";

        public bool Bool => !LeftOperand.Bool || RightOperand.Bool;
    }
}