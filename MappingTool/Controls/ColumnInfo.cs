using System;
using System.Data;
using MappingTool.Objects;

namespace MappingTool.Controls
{
    public partial class ColumnInfo : UserControl
    {
        private Column column;

        public ColumnInfo(Column column)
        {
            InitializeComponent();

            this.SuspendLayout();

            this.column = column;

            chkPrimary.Checked = column.Primary;
            txtName.Text = column.Name;
            txtTypeSql.Text = ToTypeSqlWithSizeString(column.TypeSql, column.SizeSql);
            txtTypeNet.Text = column.TypeNet.Name;
            chkIdentity.Checked = column.Identity;
            chkEnabled.Checked = column.Enabled;

            SetToolTip(chkPrimary, "Primary");
            SetToolTip(txtName, "Table Name");
            SetToolTip(txtTypeSql, "SQL Type");
            SetToolTip(txtTypeNet, ".Net Type");
            SetToolTip(chkIdentity, "Identity");

            this.ResumeLayout();
        }

        private void SetToolTip(Control control, string tooltip)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(control, tooltip);
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkEnabled = (CheckBox)sender;
            column.Enabled = chkEnabled.Checked;
        }

        private void chkPrimary_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkPrimary = (CheckBox)sender;
            column.Primary = chkPrimary.Checked;
        }

        private void chkIdentity_CheckedChanged(object sender, EventArgs e)
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
