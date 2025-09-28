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
            PnlMain = new TableLayoutPanel();
            ChkEnabled = new CheckBox();
            ChkIdentity = new CheckBox();
            TxtTypeNet = new TextBox();
            TxtTypeSql = new TextBox();
            TxtName = new TextBox();
            ChkPrimary = new CheckBox();
            PnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.ColumnCount = 6;
            PnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            PnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            PnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            PnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PnlMain.Controls.Add(ChkEnabled, 0, 0);
            PnlMain.Controls.Add(ChkIdentity, 5, 0);
            PnlMain.Controls.Add(TxtTypeNet, 4, 0);
            PnlMain.Controls.Add(TxtTypeSql, 3, 0);
            PnlMain.Controls.Add(TxtName, 2, 0);
            PnlMain.Controls.Add(ChkPrimary, 1, 0);
            PnlMain.Dock = DockStyle.Fill;
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.RowCount = 1;
            PnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlMain.Size = new Size(540, 30);
            PnlMain.TabIndex = 0;
            // 
            // ChkEnabled
            // 
            ChkEnabled.AutoSize = true;
            ChkEnabled.CheckAlign = ContentAlignment.MiddleCenter;
            ChkEnabled.Dock = DockStyle.Fill;
            ChkEnabled.Location = new Point(3, 3);
            ChkEnabled.Name = "ChkEnabled";
            ChkEnabled.Size = new Size(48, 24);
            ChkEnabled.TabIndex = 6;
            ChkEnabled.TextAlign = ContentAlignment.MiddleCenter;
            ChkEnabled.UseVisualStyleBackColor = true;
            ChkEnabled.CheckedChanged += ChkEnabled_CheckedChanged;
            // 
            // ChkIdentity
            // 
            ChkIdentity.AutoSize = true;
            ChkIdentity.CheckAlign = ContentAlignment.MiddleCenter;
            ChkIdentity.Dock = DockStyle.Fill;
            ChkIdentity.Location = new Point(489, 3);
            ChkIdentity.Name = "ChkIdentity";
            ChkIdentity.Size = new Size(48, 24);
            ChkIdentity.TabIndex = 4;
            ChkIdentity.TextAlign = ContentAlignment.MiddleCenter;
            ChkIdentity.UseVisualStyleBackColor = true;
            ChkIdentity.CheckedChanged += ChkIdentity_CheckedChanged;
            // 
            // TxtTypeNet
            // 
            TxtTypeNet.Dock = DockStyle.Fill;
            TxtTypeNet.Location = new Point(408, 3);
            TxtTypeNet.Name = "TxtTypeNet";
            TxtTypeNet.ReadOnly = true;
            TxtTypeNet.Size = new Size(75, 23);
            TxtTypeNet.TabIndex = 2;
            // 
            // TxtTypeSql
            // 
            TxtTypeSql.Dock = DockStyle.Fill;
            TxtTypeSql.Location = new Point(327, 3);
            TxtTypeSql.Name = "TxtTypeSql";
            TxtTypeSql.ReadOnly = true;
            TxtTypeSql.Size = new Size(75, 23);
            TxtTypeSql.TabIndex = 1;
            // 
            // TxtName
            // 
            TxtName.Dock = DockStyle.Fill;
            TxtName.Location = new Point(111, 3);
            TxtName.Name = "TxtName";
            TxtName.ReadOnly = true;
            TxtName.Size = new Size(210, 23);
            TxtName.TabIndex = 0;
            // 
            // ChkPrimary
            // 
            ChkPrimary.AutoSize = true;
            ChkPrimary.CheckAlign = ContentAlignment.MiddleCenter;
            ChkPrimary.Dock = DockStyle.Fill;
            ChkPrimary.Location = new Point(57, 3);
            ChkPrimary.Name = "ChkPrimary";
            ChkPrimary.Size = new Size(48, 24);
            ChkPrimary.TabIndex = 5;
            ChkPrimary.TextAlign = ContentAlignment.MiddleCenter;
            ChkPrimary.UseVisualStyleBackColor = true;
            ChkPrimary.CheckedChanged += ChkPrimary_CheckedChanged;
            // 
            // ColumnInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnlMain);
            Name = "ColumnInfo";
            Size = new Size(540, 30);
            PnlMain.ResumeLayout(false);
            PnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PnlMain;
        private TextBox TxtTypeSql;
        private TextBox TxtName;
        private TextBox TxtTypeNet;
        private CheckBox ChkIdentity;
        private CheckBox ChkPrimary;
        private CheckBox ChkEnabled;
    }
}
