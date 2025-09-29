using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MappingTool.Objects
{
    public class Class
    {
        #region PRIVATE MEMBERS

        private bool useNamespace = false;
        private string classNamespace = string.Empty;
        private string className;
        private readonly Table table;

        #endregion

        #region PUBLIC PROPERTIES

        public bool UseNamespace { get => useNamespace; set => useNamespace = value; }
        public string Namespace { get => classNamespace; set => classNamespace = value; }
        public string Name { get => className; set => className = value; }
        public Table Table { get => table; }

        #endregion

        public Class(Table table)
        {
            this.table = table;
            this.className = table.QualifiedName.Table;
        }
    }
}
