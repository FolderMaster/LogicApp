using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PropositionalLogicApp.Models;
using PropositionalLogicApp.Models.LogicVariables;
using PropositionalLogicApp.Models.LogicOperators.PairLogicOperators;
using System.Reflection.Emit;

namespace PropositionalLogicApp.Views.Controls
{
    public partial class LogicExpressionEditorControl : UserControl
    {
        private List<BoolVariable> _boolVariables = new List<BoolVariable>();

        private LogicExpression _logicExpression = new LogicExpression();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<BoolVariable> BoolVariables
        {
            get => _boolVariables;
            set => _boolVariables = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LogicExpression LogicExpression
        {
            get => _logicExpression;
            set => _logicExpression = value;
        }

        public LogicExpressionEditorControl()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(LogicExpression.IsEmpty)
            {
                LogicExpression.AddFirstValue(BoolVariables[0]);
            }
            else
            {
                LogicExpression.AddNonFirstValue(BoolVariables[1], new XorOperator());
            }
            TextBox.Text = LogicExpression.ToString();
        }

        private void BoolButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxManager.ShowInformation(_logicExpression.Bool.ToString());
            }
            catch (Exception ex)
            {
                MessageBoxManager.ShowError(ex.Message);
            }
        }
    }
}
