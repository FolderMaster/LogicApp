namespace PropositionalLogicApp.Models.LogicOperators.PairLogicOperators
{
    public interface IPairLogicOperator : ILogicOperator
    {
        ILogicValue LeftOperand { get; set; }

        ILogicValue RightOperand { get; set; }
    }
}