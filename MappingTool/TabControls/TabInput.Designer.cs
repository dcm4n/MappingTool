namespace MappingTool.Controls
{
    partial class TabInput
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlInput = new TableLayoutPanel();
            BtnProcessInput = new Button();
            TxtQuery = new TextBox();
            PnlInput.SuspendLayout();
            SuspendLayout();
            // 
            // PnlInput
            // 
            PnlInput.ColumnCount = 1;
            PnlInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PnlInput.Controls.Add(BtnProcessInput, 0, 1);
            PnlInput.Controls.Add(TxtQuery, 0, 0);
            PnlInput.Dock = DockStyle.Fill;
            PnlInput.Location = new Point(0, 0);
            PnlInput.Name = "PnlInput";
            PnlInput.RowCount = 2;
            PnlInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            PnlInput.Size = new Size(850, 900);
            PnlInput.TabIndex = 2;
            // 
            // BtnProcessInput
            // 
            BtnProcessInput.Dock = DockStyle.Fill;
            BtnProcessInput.Location = new Point(3, 853);
            BtnProcessInput.Name = "BtnProcessInput";
            BtnProcessInput.Size = new Size(844, 44);
            BtnProcessInput.TabIndex = 3;
            BtnProcessInput.Text = "Process Input";
            BtnProcessInput.UseVisualStyleBackColor = true;
            BtnProcessInput.Click += BtnProcessInput_Click;
            // 
            // TxtQuery
            // 
            TxtQuery.Dock = DockStyle.Fill;
            TxtQuery.Location = new Point(3, 3);
            TxtQuery.Multiline = true;
            TxtQuery.Name = "TxtQuery";
            TxtQuery.Size = new Size(844, 844);
            TxtQuery.TabIndex = 4;
            // 
            // TabInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnlInput);
            Name = "TabInput";
            Size = new Size(850, 900);
            PnlInput.ResumeLayout(false);
            PnlInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel PnlInput;
        private Button BtnProcessInput;
        private TextBox TxtQuery;
    }
}
