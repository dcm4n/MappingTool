namespace MappingTool.Controls
{
    partial class ColumnHeader
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
            LblIdentity = new Label();
            LblNetType = new Label();
            LblSqlType = new Label();
            LblName = new Label();
            LblPrimary = new Label();
            LblEnabled = new Label();
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
            PnlMain.Controls.Add(LblIdentity, 5, 0);
            PnlMain.Controls.Add(LblNetType, 4, 0);
            PnlMain.Controls.Add(LblSqlType, 3, 0);
            PnlMain.Controls.Add(LblName, 2, 0);
            PnlMain.Controls.Add(LblPrimary, 1, 0);
            PnlMain.Controls.Add(LblEnabled, 0, 0);
            PnlMain.Dock = DockStyle.Fill;
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.RowCount = 1;
            PnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlMain.Size = new Size(540, 30);
            PnlMain.TabIndex = 1;
            // 
            // LblIdentity
            // 
            LblIdentity.AutoSize = true;
            LblIdentity.Location = new Point(489, 0);
            LblIdentity.Name = "LblIdentity";
            LblIdentity.Size = new Size(47, 15);
            LblIdentity.TabIndex = 5;
            LblIdentity.Text = "Identity";
            LblIdentity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblNetType
            // 
            LblNetType.AutoSize = true;
            LblNetType.Location = new Point(408, 0);
            LblNetType.Name = "LblNetType";
            LblNetType.Size = new Size(56, 15);
            LblNetType.TabIndex = 4;
            LblNetType.Text = ".Net Type";
            LblNetType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblSqlType
            // 
            LblSqlType.AutoSize = true;
            LblSqlType.Location = new Point(327, 0);
            LblSqlType.Name = "LblSqlType";
            LblSqlType.Size = new Size(55, 15);
            LblSqlType.TabIndex = 3;
            LblSqlType.Text = "SQL Type";
            LblSqlType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(111, 0);
            LblName.Name = "LblName";
            LblName.Size = new Size(82, 15);
            LblName.TabIndex = 2;
            LblName.Text = "ColumnName";
            LblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LblPrimary
            // 
            LblPrimary.AutoSize = true;
            LblPrimary.Location = new Point(57, 0);
            LblPrimary.Name = "LblPrimary";
            LblPrimary.Size = new Size(48, 15);
            LblPrimary.TabIndex = 1;
            LblPrimary.Text = "Primary";
            LblPrimary.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblEnabled
            // 
            LblEnabled.AutoSize = true;
            LblEnabled.Location = new Point(3, 0);
            LblEnabled.Name = "LblEnabled";
            LblEnabled.Size = new Size(42, 30);
            LblEnabled.TabIndex = 0;
            LblEnabled.Text = "Enabled";
            LblEnabled.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ColumnHeader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnlMain);
            Name = "ColumnHeader";
            Size = new Size(540, 30);
            PnlMain.ResumeLayout(false);
            PnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PnlMain;
        private Label LblIdentity;
        private Label LblNetType;
        private Label LblSqlType;
        private Label LblName;
        private Label LblPrimary;
        private Label LblEnabled;
    }
}
