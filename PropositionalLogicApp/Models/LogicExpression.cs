using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PropositionalLogicApp.Models.LogicOperators;
using PropositionalLogicApp.Models.LogicOperators.PairLogicOperators;

namespace PropositionalLogicApp.Models
{
    public class LogicExpression : ILogicValue
    {
        private List<ILogicValue> _logicList = new List<ILogicValue>();

        public bool Bool
        {
            get
            {
                ILogicValue lastLogicValue = _logicList.Last();
                if(lastLogicValue == null)
                {
                    return false;
                }
                else
                {
                    return lastLogicValue.Bool;
                }
            }
        }

        public bool IsEmpty => _logicList.Count == 0;

        public LogicExpression() { }

        public void AddFirstValue(ILogicValue value)
        {
            if (!IsEmpty)
            {
                throw new InvalidOperationException();
            }
            else
            {
               _logicList.Add(value);
            }
        }

        public void AddNonFirstValue(ILogicValue value, IPairLogicOperator @operator)
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            else
            {
                @operator.LeftOperand = _logicList.Last();
                @operator.RightOperand = value;

                _logicList.Add(value);
                _logicList.Add(@operator);
            }
        }

        public void FindValue(ILogicValue value)
        {

        }

        public void RemoveValue(ILogicValue value)
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }
        }

        public void ReplaceValue(ILogicValue replaceable, ILogicValue replacing)
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }
        }

        public override string ToString() => _logicList.Last().ToString();
    }
}
