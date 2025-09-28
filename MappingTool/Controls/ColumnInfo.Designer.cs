namespace MappingTool.Controls
{
    partial class ColumnInfo
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
            pnlMain = new TableLayoutPanel();
            chkEnabled = new CheckBox();
            chkIdentity = new CheckBox();
            txtTypeNet = new TextBox();
            txtTypeSql = new TextBox();
            txtName = new TextBox();
            chkPrimary = new CheckBox();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.ColumnCount = 6;
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlMain.Controls.Add(chkEnabled, 0, 0);
            pnlMain.Controls.Add(chkIdentity, 5, 0);
            pnlMain.Controls.Add(txtTypeNet, 4, 0);
            pnlMain.Controls.Add(txtTypeSql, 3, 0);
            pnlMain.Controls.Add(txtName, 2, 0);
            pnlMain.Controls.Add(chkPrimary, 1, 0);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.RowCount = 1;
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMain.Size = new Size(617, 40);
            pnlMain.TabIndex = 0;
            // 
            // chkEnabled
            // 
            chkEnabled.AutoSize = true;
            chkEnabled.CheckAlign = ContentAlignment.MiddleCenter;
            chkEnabled.Dock = DockStyle.Fill;
            chkEnabled.Location = new Point(3, 4);
            chkEnabled.Margin = new Padding(3, 4, 3, 4);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new Size(55, 32);
            chkEnabled.TabIndex = 6;
            chkEnabled.TextAlign = ContentAlignment.MiddleCenter;
            chkEnabled.UseVisualStyleBackColor = true;
            chkEnabled.CheckedChanged += chkEnabled_CheckedChanged;
            // 
            // chkIdentity
            // 
            chkIdentity.AutoSize = true;
            chkIdentity.CheckAlign = ContentAlignment.MiddleCenter;
            chkIdentity.Dock = DockStyle.Fill;
            chkIdentity.Location = new Point(555, 4);
            chkIdentity.Margin = new Padding(3, 4, 3, 4);
            chkIdentity.Name = "chkIdentity";
            chkIdentity.Size = new Size(59, 32);
            chkIdentity.TabIndex = 4;
            chkIdentity.TextAlign = ContentAlignment.MiddleCenter;
            chkIdentity.UseVisualStyleBackColor = true;
            chkIdentity.CheckedChanged += chkIdentity_CheckedChanged;
            // 
            // txtTypeNet
            // 
            txtTypeNet.Dock = DockStyle.Fill;
            txtTypeNet.Location = new Point(463, 4);
            txtTypeNet.Margin = new Padding(3, 4, 3, 4);
            txtTypeNet.Name = "txtTypeNet";
            txtTypeNet.ReadOnly = true;
            txtTypeNet.Size = new Size(86, 27);
            txtTypeNet.TabIndex = 2;
            // 
            // txtTypeSql
            // 
            txtTypeSql.Dock = DockStyle.Fill;
            txtTypeSql.Location = new Point(371, 4);
            txtTypeSql.Margin = new Padding(3, 4, 3, 4);
            txtTypeSql.Name = "txtTypeSql";
            txtTypeSql.ReadOnly = true;
            txtTypeSql.Size = new Size(86, 27);
            txtTypeSql.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(125, 4);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(240, 27);
            txtName.TabIndex = 0;
            // 
            // chkPrimary
            // 
            chkPrimary.AutoSize = true;
            chkPrimary.CheckAlign = ContentAlignment.MiddleCenter;
            chkPrimary.Dock = DockStyle.Fill;
            chkPrimary.Location = new Point(64, 4);
            chkPrimary.Margin = new Padding(3, 4, 3, 4);
            chkPrimary.Name = "chkPrimary";
            chkPrimary.Size = new Size(55, 32);
            chkPrimary.TabIndex = 5;
            chkPrimary.TextAlign = ContentAlignment.MiddleCenter;
            chkPrimary.UseVisualStyleBackColor = true;
            chkPrimary.CheckedChanged += chkPrimary_CheckedChanged;
            // 
            // ColumnInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ColumnInfo";
            Size = new Size(617, 40);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlMain;
        private TextBox txtTypeSql;
        private TextBox txtName;
        private TextBox txtTypeNet;
        private CheckBox chkIdentity;
        private CheckBox chkPrimary;
        private CheckBox chkEnabled;
    }
}
