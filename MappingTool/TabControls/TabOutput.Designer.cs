namespace MappingTool.Controls
{
    partial class TabOutput
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
            ToolStrip = new ToolStrip();
            TxtClass = new RichTextBox();
            SuspendLayout();
            // 
            // ToolStrip
            // 
            ToolStrip.Location = new Point(0, 0);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(850, 25);
            ToolStrip.TabIndex = 0;
            ToolStrip.Text = "toolStrip1";
            // 
            // TxtClass
            // 
            TxtClass.Dock = DockStyle.Fill;
            TxtClass.Location = new Point(0, 25);
            TxtClass.Name = "TxtClass";
            TxtClass.Size = new Size(850, 875);
            TxtClass.TabIndex = 1;
            TxtClass.Text = "";
            // 
            // TabClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TxtClass);
            Controls.Add(ToolStrip);
            Name = "TabClass";
            Size = new Size(850, 900);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStrip;
        private RichTextBox TxtClass;
    }
}
