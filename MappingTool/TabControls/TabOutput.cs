using System;
using MappingTool.Output;

namespace MappingTool.Controls
{
    public partial class TabOutput : UserControl
    {
        public FrmClassBuilder? frmClassBuilder = null!;

        public TabOutput()
        {
            InitializeComponent();
        }

        public void WriteOutput(string outputClass)
        {
            TxtClass.Text = outputClass;
        }
    }
}
