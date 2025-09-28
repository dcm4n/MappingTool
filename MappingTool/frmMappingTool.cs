using MappingTool.Objects;
using MappingTool.Controls;
using MappingTool.Builder;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Text;
using MappingTool.Parser;

namespace MappingTool
{
    public partial class FrmMappingTool : Form
    {
        private readonly Table table = new();

        public FrmMappingTool()
        {
            InitializeComponent();
        }

        private void BtnProcessQuery_Click(object sender, EventArgs e)
        {
            // Query
            Query query = new(txtQuery.Text);
            txtQuery.Text = query.ParsedQuery;

            // Build Table
            table.QualifiedName = QueryTable.GetQualifiedName(query.TableNameQuery);
            table.Columns = QueryTable.GetColumns(query.ColumnQueries);

            // Column header
            MappingTool.Controls.ColumnHeader columnHeader = new();
            pnlColumns.Controls.Add(columnHeader);
            columnHeader.Width = pnlColumns.Width - 30;
            pnlColumns.SetFlowBreak(columnHeader, false);

            // Column rows
            pnlColumns.Controls.Clear();
            foreach (KeyValuePair<string, Column> column in table.Columns)
            {
                ColumnInfo columnInfo = new(column.Value);
                pnlColumns.Controls.Add(columnInfo);
                columnInfo.Width = pnlColumns.Width - 30;
                pnlColumns.SetFlowBreak(columnInfo, false);
            }
        }

        private void BtnGenerateClass_Click(object sender, EventArgs e)
        {
            table.SetColumnsEnabled();
            Builder.Builder b = new(table);
        }

    }
}
