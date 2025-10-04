using MappingTool.Input;
using MappingTool.Objects;
using System;

namespace MappingTool.Controls
{
    public partial class TabTable : UserControl
    {
        public FrmClassBuilder frmClassBuilder = null!;

        public TabTable()
        {
            InitializeComponent();
        }

        public void LoadTableInfo(QualifiedName tableName, Column[] columns)
        {
            // Table identifier
            TxtTableDatabase.Text = tableName.Database;
            TxtTableSchema.Text = tableName.Schema;
            TxtTableName.Text = tableName.Table;

            // Table columns (fill dgv)

        }

        private void BtnProcessTable_Click(object sender, EventArgs e)
        {
            Table table = new();
            table.QualifiedName = GetQualifiedName();
            table.Columns = GetColumns();

            frmClassBuilder.LoadClassInfo(table);
        }

        #region FORM HELPERS

        private QualifiedName GetQualifiedName()
        {
            QualifiedName qualifiedName = new()
            {
                Database = TxtTableDatabase.Text,
                Schema = TxtTableSchema.Text,
                Table = TxtTableName.Text
            };
            return qualifiedName;
        }

        private Dictionary<string, Column> GetColumns()
        {
            Dictionary<string, Column> columns = [];

            return columns;
        }

        #endregion
    }
}
