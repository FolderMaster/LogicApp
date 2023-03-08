namespace PropositionalLogicApp.Views.Tabs
{
    partial class MainTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoolVariableTableControl = new PropositionalLogicApp.Views.Controls.BoolVariableTableControl();
            this.BoolVariablesGroupBox = new System.Windows.Forms.GroupBox();
            this.LogicExpressionEditorControl = new PropositionalLogicApp.Views.Controls.LogicExpressionEditorControl();
            this.BoolVariablesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoolVariableTableControl
            // 
            this.BoolVariableTableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoolVariableTableControl.Location = new System.Drawing.Point(3, 16);
            this.BoolVariableTableControl.Name = "BoolVariableTableControl";
            this.BoolVariableTableControl.Size = new System.Drawing.Size(346, 460);
            this.BoolVariableTableControl.TabIndex = 0;
            // 
            // BoolVariablesGroupBox
            // 
            this.BoolVariablesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BoolVariablesGroupBox.Controls.Add(this.BoolVariableTableControl);
            this.BoolVariablesGroupBox.Location = new System.Drawing.Point(0, 29);
            this.BoolVariablesGroupBox.Name = "BoolVariablesGroupBox";
            this.BoolVariablesGroupBox.Size = new System.Drawing.Size(352, 479);
            this.BoolVariablesGroupBox.TabIndex = 1;
            this.BoolVariablesGroupBox.TabStop = false;
            this.BoolVariablesGroupBox.Text = "Bool variables";
            // 
            // logicExpressionEditorControl1
            // 
            this.LogicExpressionEditorControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicExpressionEditorControl.Location = new System.Drawing.Point(0, 0);
            this.LogicExpressionEditorControl.Name = "logicExpressionEditorControl1";
            this.LogicExpressionEditorControl.Size = new System.Drawing.Size(614, 23);
            this.LogicExpressionEditorControl.TabIndex = 2;
            // 
            // MainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogicExpressionEditorControl);
            this.Controls.Add(this.BoolVariablesGroupBox);
            this.Name = "MainTab";
            this.Size = new System.Drawing.Size(614, 508);
            this.BoolVariablesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BoolVariableTableControl BoolVariableTableControl;
        private System.Windows.Forms.GroupBox BoolVariablesGroupBox;
        private Controls.LogicExpressionEditorControl LogicExpressionEditorControl;
    }
}
