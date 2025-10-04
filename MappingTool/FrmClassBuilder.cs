using MappingTool.Controls;
using MappingTool.Input;
using MappingTool.Objects;
using MappingTool.Output;

namespace MappingTool
{
    public partial class FrmClassBuilder : Form
    {
        public FrmClassBuilder()
        {
            InitializeComponent();

            TabInput.frmClassBuilder = this;
            TabTable.frmClassBuilder = this;
            TabClass.frmClassBuilder = this;
            TabOutput.frmClassBuilder = this;

            TbpInput.Enabled = true;
            TbpTable.Enabled = false;
            TbpClass.Enabled = false;
            TbpOutput.Enabled = false;
        }

        // Called from TabInput -> Updates TabTable
        public void LoadTableInfo(QualifiedName qualifiedName, Column[] columns)
        {
            TabTable.LoadTableInfo(qualifiedName, columns);
            TbpTable.Enabled = true;
            TbcMain.SelectTab("TbpTable");
        }

        // Called from TabTable -> Updates TabClass
        public void LoadClassInfo(Table table)
        {
            TabClass.LoadClassInfo(table); 
            TbpClass.Enabled = true;
            TbcMain.SelectTab("TbpClass");
        }

        // Called from TabClass -> Updates TabOutput
        public void WriteOutput(OutputBuilder builder)
        {
            TabOutput.WriteOutput(builder.Result);
            TbpOutput.Enabled = true;
            TbcMain.SelectTab("TbpOutput");
        }
    }
}
