using MappingTool.Input;
using MappingTool.Objects;
using System;

namespace MappingTool.Controls
{
    public partial class TabInput : UserControl
    {
        public FrmClassBuilder frmClassBuilder = null!;

        public TabInput()
        {
            InitializeComponent();
        }

        private void BtnProcessInput_Click(object sender, EventArgs e)
        {
            InputQuery query = new InputQuery(TxtQuery.Text);
            TxtQuery.Text = query.ParsedQuery;

            QualifiedName qualifiedName; qualifiedName = InputQueryTable.GetQualifiedNameFromQuery(query.TableNameQuery);
            Column[] columns = InputQueryTable.GetColumnsFromQuery(query.ColumnQueries);

            frmClassBuilder.LoadTableInfo(qualifiedName, columns);
        }
    }
}
