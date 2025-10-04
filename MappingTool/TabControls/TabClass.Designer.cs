namespace MappingTool.Controls
{
    partial class TabClass
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
            PnlOptions = new TableLayoutPanel();
            BtnGenerateClass = new Button();
            PnlClassName = new TableLayoutPanel();
            TxtClassName = new TextBox();
            LblClassName = new Label();
            TxtNamespace = new TextBox();
            ChkNamespace = new CheckBox();
            PnlClassOptions = new TableLayoutPanel();
            LblUseNamespace = new Label();
            PnlOptions.SuspendLayout();
            PnlClassName.SuspendLayout();
            SuspendLayout();
            // 
            // PnlOptions
            // 
            PnlOptions.ColumnCount = 1;
            PnlOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PnlOptions.Controls.Add(BtnGenerateClass, 0, 2);
            PnlOptions.Controls.Add(PnlClassName, 0, 0);
            PnlOptions.Controls.Add(PnlClassOptions, 0, 1);
            PnlOptions.Dock = DockStyle.Fill;
            PnlOptions.Location = new Point(0, 0);
            PnlOptions.Name = "PnlOptions";
            PnlOptions.RowCount = 3;
            PnlOptions.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            PnlOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlOptions.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            PnlOptions.Size = new Size(850, 900);
            PnlOptions.TabIndex = 0;
            // 
            // BtnGenerateClass
            // 
            BtnGenerateClass.Dock = DockStyle.Fill;
            BtnGenerateClass.Location = new Point(3, 853);
            BtnGenerateClass.Name = "BtnGenerateClass";
            BtnGenerateClass.Size = new Size(844, 44);
            BtnGenerateClass.TabIndex = 3;
            BtnGenerateClass.Text = "Generate Class";
            BtnGenerateClass.UseVisualStyleBackColor = true;
            BtnGenerateClass.Click += BtnGenerateClass_Click;
            // 
            // PnlClassName
            // 
            PnlClassName.ColumnCount = 5;
            PnlClassName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            PnlClassName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            PnlClassName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            PnlClassName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            PnlClassName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            PnlClassName.Controls.Add(LblUseNamespace, 0, 0);
            PnlClassName.Controls.Add(TxtClassName, 4, 0);
            PnlClassName.Controls.Add(LblClassName, 3, 0);
            PnlClassName.Controls.Add(TxtNamespace, 2, 0);
            PnlClassName.Controls.Add(ChkNamespace, 1, 0);
            PnlClassName.Dock = DockStyle.Fill;
            PnlClassName.Location = new Point(3, 3);
            PnlClassName.Name = "PnlClassName";
            PnlClassName.RowCount = 1;
            PnlClassName.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PnlClassName.Size = new Size(844, 29);
            PnlClassName.TabIndex = 4;
            // 
            // TxtClassName
            // 
            TxtClassName.Location = new Point(608, 3);
            TxtClassName.Name = "TxtClassName";
            TxtClassName.Size = new Size(233, 23);
            TxtClassName.TabIndex = 6;
            // 
            // LblClassName
            // 
            LblClassName.AutoSize = true;
            LblClassName.Dock = DockStyle.Fill;
            LblClassName.Location = new Point(440, 3);
            LblClassName.Margin = new Padding(3);
            LblClassName.Name = "LblClassName";
            LblClassName.Size = new Size(162, 23);
            LblClassName.TabIndex = 5;
            LblClassName.Text = "Class Name";
            LblClassName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNamespace
            // 
            TxtNamespace.Enabled = false;
            TxtNamespace.Location = new Point(204, 3);
            TxtNamespace.Name = "TxtNamespace";
            TxtNamespace.Size = new Size(230, 23);
            TxtNamespace.TabIndex = 3;
            // 
            // ChkNamespace
            // 
            ChkNamespace.AutoSize = true;
            ChkNamespace.CheckAlign = ContentAlignment.MiddleCenter;
            ChkNamespace.Dock = DockStyle.Fill;
            ChkNamespace.Location = new Point(171, 3);
            ChkNamespace.Name = "ChkNamespace";
            ChkNamespace.Size = new Size(27, 23);
            ChkNamespace.TabIndex = 2;
            ChkNamespace.UseVisualStyleBackColor = true;
            ChkNamespace.CheckedChanged += ChkNamespace_CheckedChanged;
            // 
            // PnlClassOptions
            // 
            PnlClassOptions.ColumnCount = 1;
            PnlClassOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PnlClassOptions.Dock = DockStyle.Fill;
            PnlClassOptions.Location = new Point(3, 38);
            PnlClassOptions.Name = "PnlClassOptions";
            PnlClassOptions.RowCount = 2;
            PnlClassOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PnlClassOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PnlClassOptions.Size = new Size(844, 809);
            PnlClassOptions.TabIndex = 5;
            // 
            // LblUseNamespace
            // 
            LblUseNamespace.AutoSize = true;
            LblUseNamespace.Dock = DockStyle.Fill;
            LblUseNamespace.Location = new Point(3, 3);
            LblUseNamespace.Margin = new Padding(3);
            LblUseNamespace.Name = "LblUseNamespace";
            LblUseNamespace.Size = new Size(162, 23);
            LblUseNamespace.TabIndex = 7;
            LblUseNamespace.Text = "Use Namespace";
            LblUseNamespace.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TabOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PnlOptions);
            Name = "TabOptions";
            Size = new Size(850, 900);
            PnlOptions.ResumeLayout(false);
            PnlClassName.ResumeLayout(false);
            PnlClassName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PnlOptions;
        private Button BtnGenerateClass;
        private TableLayoutPanel PnlClassName;
        private CheckBox ChkNamespace;
        private TextBox TxtNamespace;
        private Label LblClassName;
        private TextBox TxtClassName;
        private TableLayoutPanel PnlClassOptions;
        private Label LblUseNamespace;
    }
}
