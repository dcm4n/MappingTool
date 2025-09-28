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
            pnlMain = new TableLayoutPanel();
            lblIdentity = new Label();
            lblNetType = new Label();
            lblSqlType = new Label();
            lblName = new Label();
            lblPrimary = new Label();
            lblEnabled = new Label();
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
            pnlMain.Controls.Add(lblIdentity, 5, 0);
            pnlMain.Controls.Add(lblNetType, 4, 0);
            pnlMain.Controls.Add(lblSqlType, 3, 0);
            pnlMain.Controls.Add(lblName, 2, 0);
            pnlMain.Controls.Add(lblPrimary, 1, 0);
            pnlMain.Controls.Add(lblEnabled, 0, 0);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.RowCount = 1;
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMain.Size = new Size(540, 30);
            pnlMain.TabIndex = 1;
            // 
            // lblIdentity
            // 
            lblIdentity.AutoSize = true;
            lblIdentity.Location = new Point(489, 0);
            lblIdentity.Name = "lblIdentity";
            lblIdentity.Size = new Size(47, 15);
            lblIdentity.TabIndex = 5;
            lblIdentity.Text = "Identity";
            lblIdentity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNetType
            // 
            lblNetType.AutoSize = true;
            lblNetType.Location = new Point(408, 0);
            lblNetType.Name = "lblNetType";
            lblNetType.Size = new Size(56, 15);
            lblNetType.TabIndex = 4;
            lblNetType.Text = ".Net Type";
            lblNetType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSqlType
            // 
            lblSqlType.AutoSize = true;
            lblSqlType.Location = new Point(327, 0);
            lblSqlType.Name = "lblSqlType";
            lblSqlType.Size = new Size(55, 15);
            lblSqlType.TabIndex = 3;
            lblSqlType.Text = "SQL Type";
            lblSqlType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(111, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 15);
            lblName.TabIndex = 2;
            lblName.Text = "ColumnName";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrimary
            // 
            lblPrimary.AutoSize = true;
            lblPrimary.Location = new Point(57, 0);
            lblPrimary.Name = "lblPrimary";
            lblPrimary.Size = new Size(48, 15);
            lblPrimary.TabIndex = 1;
            lblPrimary.Text = "Primary";
            lblPrimary.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEnabled
            // 
            lblEnabled.AutoSize = true;
            lblEnabled.Location = new Point(3, 0);
            lblEnabled.Name = "lblEnabled";
            lblEnabled.Size = new Size(42, 30);
            lblEnabled.TabIndex = 0;
            lblEnabled.Text = "Enabled";
            lblEnabled.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ColumnHeader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMain);
            Name = "ColumnHeader";
            Size = new Size(540, 30);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlMain;
        private Label lblIdentity;
        private Label lblNetType;
        private Label lblSqlType;
        private Label lblName;
        private Label lblPrimary;
        private Label lblEnabled;
    }
}
