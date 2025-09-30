using MappingTool.Parser;

namespace MappingTool.Objects
{
    public struct QualifiedName
    {
        public string Database;
        public string Schema;
        public string Table;
    }

    public class Table
    {
        #region PRIVATE MEMBERS

        private QualifiedName qualifiedName;
        private Dictionary<string, Column> columns = [];
        
        #endregion

        #region PUBLIC PROPERTIES

        public QualifiedName QualifiedName { get => qualifiedName; set => qualifiedName = value; }
        public Dictionary<string, Column> Columns { get => columns; set => columns = value; }

        #endregion

        public Table() { }

    }
}
