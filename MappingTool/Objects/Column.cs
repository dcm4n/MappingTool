using System;
using System.Data;

namespace MappingTool.Objects
{
    public class Column
    {
        #region PRIVATE FIELDS

        private string name = string.Empty;
        private SqlDbType typeSql;
        private int sizeSql;
        private Type typeNet = typeof(string);
        private bool nullable;
        private bool identity;
        private bool primary;
        private bool enabled;

        #endregion

        #region PUBLIC PROPERTIES

        public string Name { get => name; set => name = value; }
        public SqlDbType TypeSql { get => typeSql; set => typeSql = value; }
        public int SizeSql { get => sizeSql; set => sizeSql = value; }
        public Type TypeNet { get => typeNet; set => typeNet = value; }
        public bool Nullable { get => nullable; set => nullable = value; }
        public bool Primary { get => primary; set => primary = value; }
        public bool Identity { get => identity; set => identity = value; }       
        public bool Enabled { get => enabled; set => enabled = value; }

        #endregion

        public override string ToString() { return String.Concat(name); }

        public Column() 
        {

        }

    }
}
