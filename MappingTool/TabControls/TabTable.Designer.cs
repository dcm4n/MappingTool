namespace MappingTool.Controls
{
    partial class TabTable
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
            PnlTable = new TableLayoutPanel();
            BtnProcessTable = new Button();
            DgvColumns = new DataGridView();
            PnlTableName = new TableLayoutPanel();
            TxtTableName = new TextBox();
            LblTableName = new Label();
            TxtTableSchema = new TextBox();
            LblTableSchema = new Label();
            TxtTableDatabase = new TextBox();
            LblTableDatabase = new Label();
            PnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvColumns).BeginInit();
            PnlTableName.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTable
            // 
            PnlTable.ColumnCount = 1;
            PnlTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PnlTable.Controls.Add(BtnProcessTable, 0, 2);
            PnlTable.Controls.Add(DgvColumns, 0, 1);
            PnlTable.Controls.Add(PnlTableName, 0, 0);
            PnlTable.Dock = DockStyle.Fill;
            PnlTable.Location = new Point(0, 0);
            PnlTable.Name = "PnlTable";
            PnlTable.RowCount = 3;
            PnlTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            PnlTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            PnlTable.Size = new Size(850, 900);
            PnlTable.TabIndex = 0;
            // 
            // BtnProcessTable
            // 
            BtnProcessTable.Dock = DockStyle.Fill;
            BtnProcessTable.Location = new Point(3, 853);
            BtnProcessTable.Name = "BtnProcessTable";
            BtnProcessTable.Size = new Size(844, 44);
            BtnProcessTable.TabIndex = 4;
            BtnProcessTable.Text = "Process Table";
            BtnProcessTable.UseVisualStyleBackColor = true;
            BtnProcessTable.Click += BtnProcessTable_Click;
            // 
            // DgvColumns
            // 
            DgvColumns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvColumns.Dock = DockStyle.Fill;
            DgvColumns.Location = new Point(3, 38);
            DgvColumns.Name = "DgvColumns";
            DgvColumns.Size = new Size(844, 809);
            DgvColumns.TabIndex = 5;
            // 
            // PnlTableName
            // 
            PnlTableName.ColumnCount = 6;
            PnlTableName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PnlTableName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            PnlTableName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PnlTableName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            PnlTableName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PnlTableName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            PnlTableName.Controls.Add(TxtTableName, 5, 0);
            PnlTableName.Controls.Add(LblTableName, 4, 0);
            PnlTableName.Controls.Add(TxtTableSchema, 3, 0);
            PnlTableName.Controls.Add(LblTableSchema, 2, 0);
            PnlTableName.Controls.Add(TxtTableDatabase, 1, 0);
            PnlTableName.Controls.Add(LblTableDatabase, 0, 0);
            PnlTableName.Dock = DockStyle.Fill;
            PnlTableName.Location = new Point(3, 3);
            PnlTableName.Name = "PnlTableName";
            PnlTableName.RowCount = 1;
            PnlTableName.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlTableName.Size = new Size(844, 29);
            PnlTableName.TabIndex = 6;
            // 
            // TxtTableName
            // 
            TxtTableName.Dock = DockStyle.Fill;
            TxtTableName.Location = new Point(591, 3);
            TxtTableName.Name = "TxtTableName";
            TxtTableName.Size = new Size(250, 23);
            TxtTableName.TabIndex = 6;
            // 
            // LblTableName
            // 
            LblTableName.AutoSize = true;
            LblTableName.Dock = DockStyle.Fill;
            LblTableName.Location = new Point(507, 3);
            LblTableName.Margin = new Padding(3);
            LblTableName.Name = "LblTableName";
            LblTableName.Size = new Size(78, 23);
            LblTableName.TabIndex = 5;
            LblTableName.Text = "Name";
            LblTableName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtTableSchema
            // 
            TxtTableSchema.Dock = DockStyle.Fill;
            TxtTableSchema.Location = new Point(339, 3);
            TxtTableSchema.Name = "TxtTableSchema";
            TxtTableSchema.Size = new Size(162, 23);
            TxtTableSchema.TabIndex = 4;
            // 
            // LblTableSchema
            // 
            LblTableSchema.AutoSize = true;
            LblTableSchema.Dock = DockStyle.Fill;
            LblTableSchema.Location = new Point(255, 3);
            LblTableSchema.Margin = new Padding(3);
            LblTableSchema.Name = "LblTableSchema";
            LblTableSchema.Size = new Size(78, 23);
            LblTableSchema.TabIndex = 3;
            LblTableSchema.Text = "Schema";
            LblTableSchema.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtTableDatabase
            // 
            TxtTableDatabase.Dock = DockStyle.Fill;
            TxtTableDatabase.Location = new Point(87, 3);
            TxtTableDatabase.Name = "TxtTableDatabase";
            TxtTableDatabase.Size = new Size(162, 23);
            TxtTableDatabase.TabIndex = 2;
            // 
            // LblTableDatabase
            // 
            LblTableDatabase.AutoSize = true;
            LblTableDatabase.Dock = DockStyle.Fill;
            LblTableDatabase.Location = new Point(3, 3);
            LblTableDatabase.Margin = new Padding(3);
            LblTableDatabase.Name = "LblTableDatabase";
            LblTableDatabase.Size = new Size(78, 23);
            LblTableDatabase.TabIndex = 1;
            LblTableDatabase.Text = "Database";
            LblTableDatabase.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TabTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnlTable);
            Name = "TabTable";
            Size = new Size(850, 900);
            PnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvColumns).EndInit();
            PnlTableName.ResumeLayout(false);
            PnlTableName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PnlTable;
        private Button BtnProcessTable;
        private DataGridView DgvColumns;
        private TableLayoutPanel PnlTableName;
        private Label LblTableDatabase;
        private TextBox TxtTableDatabase;
        private Label LblTableSchema;
        private TextBox TxtTableSchema;
        private Label LblTableName;
        private TextBox TxtTableName;
    }
}
