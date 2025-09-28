namespace MappingTool
{
    partial class FrmMappingTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new TableLayoutPanel();
            pnlBody = new TableLayoutPanel();
            pnlInfo = new TableLayoutPanel();
            btnGenerateClass = new Button();
            pnlColumns = new FlowLayoutPanel();
            pnlQuery = new TableLayoutPanel();
            txtQuery = new RichTextBox();
            btnProcessQuery = new Button();
            pnlHeader = new TableLayoutPanel();
            pnlMain.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlInfo.SuspendLayout();
            pnlQuery.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.ColumnCount = 1;
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlMain.Controls.Add(pnlBody, 0, 1);
            pnlMain.Controls.Add(pnlHeader, 0, 0);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.RowCount = 2;
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMain.Size = new Size(1540, 845);
            pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            pnlBody.ColumnCount = 2;
            pnlBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlBody.Controls.Add(pnlInfo, 1, 0);
            pnlBody.Controls.Add(pnlQuery, 0, 0);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(3, 63);
            pnlBody.Name = "pnlBody";
            pnlBody.RowCount = 1;
            pnlBody.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlBody.Size = new Size(1534, 779);
            pnlBody.TabIndex = 0;
            // 
            // pnlInfo
            // 
            pnlInfo.ColumnCount = 1;
            pnlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlInfo.Controls.Add(btnGenerateClass, 0, 1);
            pnlInfo.Controls.Add(pnlColumns, 0, 0);
            pnlInfo.Dock = DockStyle.Fill;
            pnlInfo.Location = new Point(770, 3);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.RowCount = 2;
            pnlInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            pnlInfo.Size = new Size(761, 773);
            pnlInfo.TabIndex = 1;
            // 
            // btnGenerateClass
            // 
            btnGenerateClass.Dock = DockStyle.Fill;
            btnGenerateClass.Location = new Point(3, 716);
            btnGenerateClass.Name = "btnGenerateClass";
            btnGenerateClass.Size = new Size(755, 54);
            btnGenerateClass.TabIndex = 2;
            btnGenerateClass.Text = "Generate Class";
            btnGenerateClass.UseVisualStyleBackColor = true;
            btnGenerateClass.Click += BtnGenerateClass_Click;
            // 
            // pnlColumns
            // 
            pnlColumns.AutoScroll = true;
            pnlColumns.Dock = DockStyle.Fill;
            pnlColumns.FlowDirection = FlowDirection.TopDown;
            pnlColumns.Location = new Point(3, 3);
            pnlColumns.Name = "pnlColumns";
            pnlColumns.Size = new Size(755, 707);
            pnlColumns.TabIndex = 3;
            pnlColumns.WrapContents = false;
            // 
            // pnlQuery
            // 
            pnlQuery.ColumnCount = 1;
            pnlQuery.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlQuery.Controls.Add(txtQuery, 0, 0);
            pnlQuery.Controls.Add(btnProcessQuery, 0, 1);
            pnlQuery.Dock = DockStyle.Fill;
            pnlQuery.Location = new Point(3, 3);
            pnlQuery.Name = "pnlQuery";
            pnlQuery.RowCount = 2;
            pnlQuery.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlQuery.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            pnlQuery.Size = new Size(761, 773);
            pnlQuery.TabIndex = 0;
            // 
            // txtQuery
            // 
            txtQuery.Dock = DockStyle.Fill;
            txtQuery.Location = new Point(3, 3);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(755, 707);
            txtQuery.TabIndex = 0;
            txtQuery.Text = "";
            txtQuery.WordWrap = false;
            // 
            // btnProcessQuery
            // 
            btnProcessQuery.Dock = DockStyle.Fill;
            btnProcessQuery.Location = new Point(3, 716);
            btnProcessQuery.Name = "btnProcessQuery";
            btnProcessQuery.Size = new Size(755, 54);
            btnProcessQuery.TabIndex = 1;
            btnProcessQuery.Text = "Process Query";
            btnProcessQuery.UseVisualStyleBackColor = true;
            btnProcessQuery.Click += BtnProcessQuery_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.ColumnCount = 2;
            pnlHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.RowCount = 1;
            pnlHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlHeader.Size = new Size(1534, 54);
            pnlHeader.TabIndex = 1;
            // 
            // FrmMappingTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1540, 845);
            Controls.Add(pnlMain);
            Name = "FrmMappingTool";
            Text = "Form1";
            pnlMain.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlQuery.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlMain;
        private TableLayoutPanel pnlBody;
        private TableLayoutPanel pnlHeader;
        private TableLayoutPanel pnlInfo;
        private Button btnGenerateClass;
        private TableLayoutPanel pnlQuery;
        private RichTextBox txtQuery;
        private Button btnProcessQuery;
        private FlowLayoutPanel pnlColumns;
    }
}
