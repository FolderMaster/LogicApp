namespace PropositionalLogicApp.Models.LogicOperators.SimpleLogicOperators
{
    public interface ISimpleLogicOperator : ILogicOperator
    {
        ILogicValue Operand { get; set; }
    }
}