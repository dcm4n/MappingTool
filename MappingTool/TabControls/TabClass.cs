using MappingTool.Objects;
using MappingTool.Output;
using System;

namespace MappingTool.Controls
{
    public partial class TabClass : UserControl
    {
        public FrmClassBuilder frmClassBuilder = null!;

        public TabClass()
        {
            InitializeComponent();
        }

        public void LoadClassInfo(Table table)
        {
            // Class identifier
            ChkNamespace.Checked = false;
            TxtNamespace.Text = string.Empty;
            TxtClassName.Text = table.QualifiedName.Table;

            // Default options

        }

        private void BtnGenerateClass_Click(object sender, EventArgs e)
        {
            Class outputClass = new();
            outputClass.Name = TxtClassName.Text;
            outputClass.UseNamespace = ChkNamespace.Checked;
            outputClass.Namespace = TxtNamespace.Text;

            // Load options from frm


            // Build class
            OutputBuilder builder = new(outputClass);

            frmClassBuilder.WriteOutput(builder);
        }

        #region UI EVENTS

        private void ChkNamespace_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkbox = (CheckBox)sender;
            TxtNamespace.Enabled = chkbox.Checked;
        }

        #endregion
    }
}
