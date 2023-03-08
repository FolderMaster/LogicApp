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

namespace PropositionalLogicApp.Views.Tabs
{
    public partial class MainTab : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<BoolVariable> BoolVariables
        {
            get => BoolVariableTableControl.BoolVariables;
            set => BoolVariableTableControl.BoolVariables =
                LogicExpressionEditorControl.BoolVariables = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LogicExpression LogicExpression
        {
            get => LogicExpressionEditorControl.LogicExpression;
            set => LogicExpressionEditorControl.LogicExpression = value;
        }

        public MainTab()
        {
            InitializeComponent();
        }
    }
}
