using System;

namespace MappingTool.Objects
{
    public class Class
    {
        #region PRIVATE MEMBERS

        private bool useNamespace = false;
        private string classNamespace = string.Empty;
        private string className = string.Empty;
        private Table table = new();

        #endregion

        #region PUBLIC PROPERTIES

        public bool UseNamespace { get => useNamespace; set => useNamespace = value; }
        public string Namespace { get => classNamespace; set => classNamespace = value; }
        public string Name { get => className; set => className = value; }
        public Table Table { get => table; set => table = value; }

        #endregion

        public Class()
        {

        }
    }
}
