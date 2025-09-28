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
            PnlMain = new TableLayoutPanel();
            PnlBody = new TableLayoutPanel();
            PnlInfo = new TableLayoutPanel();
            BtnGenerateClass = new Button();
            PnlColumns = new FlowLayoutPanel();
            PnlQuery = new TableLayoutPanel();
            TxtQuery = new RichTextBox();
            BtnProcessQuery = new Button();
            PnlHeader = new TableLayoutPanel();
            PnlMain.SuspendLayout();
            PnlBody.SuspendLayout();
            PnlInfo.SuspendLayout();
            PnlQuery.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.ColumnCount = 1;
            PnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PnlMain.Controls.Add(PnlBody, 0, 1);
            PnlMain.Controls.Add(PnlHeader, 0, 0);
            PnlMain.Dock = DockStyle.Fill;
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.RowCount = 2;
            PnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            PnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlMain.Size = new Size(1540, 845);
            PnlMain.TabIndex = 0;
            // 
            // PnlBody
            // 
            PnlBody.ColumnCount = 2;
            PnlBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PnlBody.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PnlBody.Controls.Add(PnlInfo, 1, 0);
            PnlBody.Controls.Add(PnlQuery, 0, 0);
            PnlBody.Dock = DockStyle.Fill;
            PnlBody.Location = new Point(3, 63);
            PnlBody.Name = "PnlBody";
            PnlBody.RowCount = 1;
            PnlBody.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PnlBody.Size = new Size(1534, 779);
            PnlBody.TabIndex = 0;
            // 
            // PnlInfo
            // 
            PnlInfo.ColumnCount = 1;
            PnlInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PnlInfo.Controls.Add(BtnGenerateClass, 0, 1);
            PnlInfo.Controls.Add(PnlColumns, 0, 0);
            PnlInfo.Dock = DockStyle.Fill;
            PnlInfo.Location = new Point(770, 3);
            PnlInfo.Name = "PnlInfo";
            PnlInfo.RowCount = 2;
            PnlInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            PnlInfo.Size = new Size(761, 773);
            PnlInfo.TabIndex = 1;
            // 
            // BtnGenerateClass
            // 
            BtnGenerateClass.Dock = DockStyle.Fill;
            BtnGenerateClass.Location = new Point(3, 716);
            BtnGenerateClass.Name = "BtnGenerateClass";
            BtnGenerateClass.Size = new Size(755, 54);
            BtnGenerateClass.TabIndex = 2;
            BtnGenerateClass.Text = "Generate Class";
            BtnGenerateClass.UseVisualStyleBackColor = true;
            BtnGenerateClass.Click += BtnGenerateClass_Click;
            // 
            // PnlColumns
            // 
            PnlColumns.AutoScroll = true;
            PnlColumns.Dock = DockStyle.Fill;
            PnlColumns.FlowDirection = FlowDirection.TopDown;
            PnlColumns.Location = new Point(3, 3);
            PnlColumns.Name = "PnlColumns";
            PnlColumns.Size = new Size(755, 707);
            PnlColumns.TabIndex = 3;
            PnlColumns.WrapContents = false;
            // 
            // PnlQuery
            // 
            PnlQuery.ColumnCount = 1;
            PnlQuery.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PnlQuery.Controls.Add(TxtQuery, 0, 0);
            PnlQuery.Controls.Add(BtnProcessQuery, 0, 1);
            PnlQuery.Dock = DockStyle.Fill;
            PnlQuery.Location = new Point(3, 3);
            PnlQuery.Name = "PnlQuery";
            PnlQuery.RowCount = 2;
            PnlQuery.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlQuery.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            PnlQuery.Size = new Size(761, 773);
            PnlQuery.TabIndex = 0;
            // 
            // TxtQuery
            // 
            TxtQuery.Dock = DockStyle.Fill;
            TxtQuery.Location = new Point(3, 3);
            TxtQuery.Name = "TxtQuery";
            TxtQuery.Size = new Size(755, 707);
            TxtQuery.TabIndex = 0;
            TxtQuery.Text = "";
            TxtQuery.WordWrap = false;
            // 
            // BtnProcessQuery
            // 
            BtnProcessQuery.Dock = DockStyle.Fill;
            BtnProcessQuery.Location = new Point(3, 716);
            BtnProcessQuery.Name = "BtnProcessQuery";
            BtnProcessQuery.Size = new Size(755, 54);
            BtnProcessQuery.TabIndex = 1;
            BtnProcessQuery.Text = "Process Query";
            BtnProcessQuery.UseVisualStyleBackColor = true;
            BtnProcessQuery.Click += BtnProcessQuery_Click;
            // 
            // PnlHeader
            // 
            PnlHeader.ColumnCount = 2;
            PnlHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PnlHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PnlHeader.Dock = DockStyle.Fill;
            PnlHeader.Location = new Point(3, 3);
            PnlHeader.Name = "PnlHeader";
            PnlHeader.RowCount = 1;
            PnlHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            PnlHeader.Size = new Size(1534, 54);
            PnlHeader.TabIndex = 1;
            // 
            // FrmMappingTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1540, 845);
            Controls.Add(PnlMain);
            Name = "FrmMappingTool";
            Text = "Form1";
            PnlMain.ResumeLayout(false);
            PnlBody.ResumeLayout(false);
            PnlInfo.ResumeLayout(false);
            PnlQuery.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PnlMain;
        private TableLayoutPanel PnlBody;
        private TableLayoutPanel PnlHeader;
        private TableLayoutPanel PnlInfo;
        private Button BtnGenerateClass;
        private TableLayoutPanel PnlQuery;
        private RichTextBox TxtQuery;
        private Button BtnProcessQuery;
        private FlowLayoutPanel PnlColumns;
    }
}
