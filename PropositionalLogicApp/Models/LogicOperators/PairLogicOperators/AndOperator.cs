namespace PropositionalLogicApp.Models.LogicOperators.PairLogicOperators
{
    public class AndOperator : IPairLogicOperator
    {
        public ILogicValue LeftOperand { get; set; }

        public ILogicValue RightOperand { get; set; }

        public string Char => "AND";

        public bool Bool => LeftOperand.Bool && RightOperand.Bool;

        public override string ToString() => $"{LeftOperand} & {RightOperand}";
    }
}