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
        public FrmMappingTool()
        {
            InitializeComponent();
        }

        private void BtnProcessQuery_Click(object sender, EventArgs e)
        {
            // Query
            Query query = new(TxtQuery.Text);
            TxtQuery.Text = query.ParsedQuery;

            // Build temp Table
            Table table = new()
            {
                QualifiedName = QueryTable.GetQualifiedNameFromQuery(query.TableNameQuery),
                Columns = QueryTable.GetColumnsFromQuery(query.ColumnQueries)
            };

            // Paint FRM Class info
            //ChkUseNamespace.Checked = false;
            //TxtClassNamespace.Text = string.Empty;
            //TxtClassName.Text = table.QualifiedName.Table;

            // Paint FRM Table info
            //TxtTableDatabase.Text = table.QualifiedName.Database;
            //TxtTableSchema.Text = table.QualifiedName.Schema;
            //TxtTableName.Text = table.QualifiedName.Table;

            // Paint FRM Column rows
            PnlColumns.SuspendLayout();
            PnlColumns.Controls.Clear();
            foreach (KeyValuePair<string, Column> column in table.Columns)
            {
                ColumnInfo columnInfo = new(column.Value);
                PnlColumns.Controls.Add(columnInfo);
                columnInfo.Width = PnlColumns.Width - 30;
                PnlColumns.SetFlowBreak(columnInfo, false);
            }
            PnlColumns.ResumeLayout();
        }

        private void BtnGenerateClass_Click(object sender, EventArgs e)
        {
            // Build table class from frm
            Table table = new()
            {
                QualifiedName = GetQulifiedNameFromFrm(),
                Columns = GetColumnsFromFrm()
            };

            // Build table class from frm
            Class frmTableClass = new()
            {
                //UseNamespace = ChkUseNamespace.Checked,
                //Namespace = TxtClassNamespace.Text,
                //Name = TxtClassName.Text,
                Table = table
            };

            // Build class
            Builder.Builder builder = new(frmTableClass);        
        }

        private QualifiedName GetQulifiedNameFromFrm()
        {
            QualifiedName qualifiedName = new()
            {
                //Database = TxtTableDatabase.Text,
                //Schema = TxtTableSchema.Text,
                //Table = TxtTableName.Text
            };

            return qualifiedName;
        }

        private Dictionary<string, Column> GetColumnsFromFrm()
        {
            Dictionary<string, Column> columns = [];
            foreach (ColumnInfo columnInfo in PnlColumns.Controls)
            {
                if (columnInfo.Column.Enabled) { columns.Add(columnInfo.Column.Name, columnInfo.Column); }
            }
            return columns;
        }
    }
}
