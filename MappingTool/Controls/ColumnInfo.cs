using System;
using System.Data;
using MappingTool.Objects;

namespace MappingTool.Controls
{
    public partial class ColumnInfo : UserControl
    {
        private readonly Column column;

        public ColumnInfo(Column column)
        {
            InitializeComponent();

            this.SuspendLayout();

            this.column = column;

            ChkPrimary.Checked = column.Primary;
            TxtName.Text = column.Name;
            TxtTypeSql.Text = ToTypeSqlWithSizeString(column.TypeSql, column.SizeSql);
            TxtTypeNet.Text = column.TypeNet.Name;
            ChkIdentity.Checked = column.Identity;
            ChkEnabled.Checked = column.Enabled;

            SetToolTip(ChkPrimary, "Primary");
            SetToolTip(TxtName, "Table Name");
            SetToolTip(TxtTypeSql, "SQL Type");
            SetToolTip(TxtTypeNet, ".Net Type");
            SetToolTip(ChkIdentity, "Identity");

            this.ResumeLayout();
        }

        private static void SetToolTip(Control control, string tooltip)
        {
            ToolTip toolTip1 = new();
            toolTip1.SetToolTip(control, tooltip);
        }

        private void ChkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkEnabled = (CheckBox)sender;
            column.Enabled = chkEnabled.Checked;
        }

        private void ChkPrimary_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkPrimary = (CheckBox)sender;
            column.Primary = chkPrimary.Checked;
        }

        private void ChkIdentity_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkIdentity = (CheckBox)sender;
            column.Identity = chkIdentity.Checked;
        }

        private static string ToTypeSqlWithSizeString(SqlDbType typeSql, int sizeSql)
        {
            string type = typeSql.ToString();
            if (sizeSql < 0) { type += "(MAX)"; }
            if (sizeSql > 0) { type += "(" + sizeSql.ToString() + ")"; }
            return type;
        }
    }
}
