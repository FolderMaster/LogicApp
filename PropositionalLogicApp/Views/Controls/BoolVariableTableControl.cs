using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PropositionalLogicApp.Models.LogicVariables;

namespace PropositionalLogicApp.Views.Controls
{
    public partial class BoolVariableTableControl : UserControl
    {
        private BindingList<BoolVariable> _bindingList = new BindingList<BoolVariable>();

        private BindingSource _bindingSource = new BindingSource();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<BoolVariable> BoolVariables
        {
            get => _bindingList.ToList();
            set
            {
                _bindingList = new BindingList<BoolVariable>(value);
                _bindingSource.DataSource = _bindingList;
            }
        }

        public BoolVariableTableControl()
        {
            InitializeComponent();

            _bindingSource.DataSource = _bindingList;
            DataGridView.DataSource = _bindingSource;
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView[e.ColumnIndex, e.RowIndex].ErrorText = e.Exception.Message;
            e.Cancel = true;
        }

        private void DataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView[e.ColumnIndex, e.RowIndex].ErrorText = null;
        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs
            e)
        {
            PropertyInfo propertyInfo = typeof(BoolVariable).GetProperties()[e.ColumnIndex];
            if (propertyInfo.CanWrite)
            {
                try
                {
                    propertyInfo.SetValue(_bindingList[e.RowIndex], e.FormattedValue);
                }
                catch (Exception ex)
                {
                    DataGridView[e.ColumnIndex, e.RowIndex].ErrorText = ex.Message;
                    e.Cancel = true;
                }
            }
        }
    }
}
