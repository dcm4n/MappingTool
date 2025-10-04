namespace MappingTool
{
    partial class FrmClassBuilder
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
            StatusStrip = new StatusStrip();
            TbcMain = new TabControl();
            TbpInput = new TabPage();
            TabInput = new MappingTool.Controls.TabInput();
            TbpTable = new TabPage();
            TabTable = new MappingTool.Controls.TabTable();
            TbpClass = new TabPage();
            TabClass = new MappingTool.Controls.TabClass();
            TbpOutput = new TabPage();
            TabOutput = new MappingTool.Controls.TabOutput();   
            TbcMain.SuspendLayout();
            TbpInput.SuspendLayout();
            TbpTable.SuspendLayout();
            TbpClass.SuspendLayout();
            TbpOutput.SuspendLayout();
            SuspendLayout();
            // 
            // StatusStrip
            // 
            StatusStrip.Location = new Point(0, 835);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(830, 22);
            StatusStrip.TabIndex = 2;
            StatusStrip.Text = "statusStrip1";
            // 
            // TbcMain
            // 
            TbcMain.Controls.Add(TbpInput);
            TbcMain.Controls.Add(TbpTable);
            TbcMain.Controls.Add(TbpClass);
            TbcMain.Controls.Add(TbpOutput);
            TbcMain.Dock = DockStyle.Fill;
            TbcMain.Location = new Point(0, 0);
            TbcMain.Name = "TbcMain";
            TbcMain.SelectedIndex = 0;
            TbcMain.Size = new Size(830, 835);
            TbcMain.TabIndex = 5;
            // 
            // TbpInput
            // 
            TbpInput.Controls.Add(TabInput);
            TbpInput.Location = new Point(4, 24);
            TbpInput.Name = "TbpInput";
            TbpInput.Padding = new Padding(3);
            TbpInput.Size = new Size(822, 807);
            TbpInput.TabIndex = 0;
            TbpInput.Text = "Input";
            TbpInput.UseVisualStyleBackColor = true;
            // 
            // TabInput
            // 
            TabInput.Dock = DockStyle.Fill;
            TabInput.Location = new Point(3, 3);
            TabInput.Name = "TabInput";
            TabInput.Size = new Size(816, 801);
            TabInput.TabIndex = 0;
            // 
            // TbpTable
            // 
            TbpTable.Controls.Add(TabTable);
            TbpTable.Location = new Point(4, 24);
            TbpTable.Name = "TbpTable";
            TbpTable.Padding = new Padding(3);
            TbpTable.Size = new Size(822, 807);
            TbpTable.TabIndex = 1;
            TbpTable.Text = "Table";
            TbpTable.UseVisualStyleBackColor = true;
            // 
            // TabTable
            // 
            TabTable.Dock = DockStyle.Fill;
            TabTable.Location = new Point(3, 3);
            TabTable.Name = "TabTable";
            TabTable.Size = new Size(816, 801);
            TabTable.TabIndex = 0;
            // 
            // TbpClass
            // 
            TbpClass.Controls.Add(TabClass);
            TbpClass.Location = new Point(4, 24);
            TbpClass.Name = "TbpClass";
            TbpClass.Padding = new Padding(3);
            TbpClass.Size = new Size(822, 807);
            TbpClass.TabIndex = 2;
            TbpClass.Text = "Class";
            TbpClass.UseVisualStyleBackColor = true;
            // 
            // TbpOutput
            // 
            TbpOutput.Controls.Add(TabOutput);
            TbpOutput.Location = new Point(4, 24);
            TbpOutput.Name = "TbpOutput";
            TbpOutput.Padding = new Padding(3);
            TbpOutput.Size = new Size(822, 807);
            TbpOutput.TabIndex = 3;
            TbpOutput.Text = "Output";
            TbpOutput.UseVisualStyleBackColor = true;
            // 
            // TabOutput
            // 
            TabOutput.Dock = DockStyle.Fill;
            TabOutput.Location = new Point(3, 3);
            TabOutput.Name = "TabOutput";
            TabOutput.Size = new Size(816, 801);
            TabOutput.TabIndex = 0;
            // 
            // TabClass
            // 
            TabClass.Dock = DockStyle.Fill;
            TabClass.Location = new Point(3, 3);
            TabClass.Name = "TabClass";
            TabClass.Size = new Size(816, 801);
            TabClass.TabIndex = 0;
            // 
            // FrmClassBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(830, 857);
            Controls.Add(TbcMain);
            Controls.Add(StatusStrip);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmClassBuilder";
            Text = "Form1";
            TbcMain.ResumeLayout(false);
            TbpInput.ResumeLayout(false);
            TbpTable.ResumeLayout(false);
            TbpClass.ResumeLayout(false);
            TbpOutput.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip StatusStrip;
        private TabPage TbpOutput;
        private TabPage TbpInput;
        private TabPage TbpTable;
        private TabPage TbpClass;
        private TabControl TbcMain;
        public Controls.TabInput TabInput;
        public Controls.TabTable TabTable;
        private Controls.TabOutput TabOutput;
        private Controls.TabClass TabClass;
    }
}
