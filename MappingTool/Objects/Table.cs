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
        private Dictionary<string, Column> columnsEnabled = [];
        

        #endregion

        #region PUBLIC PROPERTIES

        public QualifiedName QualifiedName { get => qualifiedName; set => qualifiedName = value; }

        public Dictionary<string, Column> Columns { get => columns; set => columns = value; }

        public Dictionary<string, Column> ColumnsEnabled { get => columnsEnabled; set => columnsEnabled = value; }

        #endregion

        public Table() { }

        public void SetColumnsEnabled()
        {  
            foreach (KeyValuePair<string, Column> column in columns) 
            { 
                if (column.Value.Enabled) 
                { 
                    columnsEnabled[column.Key] = column.Value; 
                } 
            }
        }
    }
}
