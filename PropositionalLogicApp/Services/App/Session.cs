using System.Collections.Generic;

using PropositionalLogicApp.Models;
using PropositionalLogicApp.Models.LogicVariables;

namespace PropositionalLogicApp.Services.App
{
    public class Session
    {
        public LogicExpression LogicExpression { get; set; } = new LogicExpression();

        public List<BoolVariable> BoolVariables { get; set; } = new List<BoolVariable>();

        public Session()
        {
        }

        public Session(LogicExpression logicExpression, List<BoolVariable> boolVariables)
        {
            LogicExpression = logicExpression;
            BoolVariables = boolVariables;
        }
    }
}