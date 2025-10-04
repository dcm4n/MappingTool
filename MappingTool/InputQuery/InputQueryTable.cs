using System;
using MappingTool.Objects;

namespace MappingTool.Input
{
    internal static class InputQueryTable
    {
        #region TABLE NAME

        public static QualifiedName GetQualifiedNameFromQuery(string queryCreateTable)
        {
            QualifiedName qualifiedName = new();
            string qualifiedTableName = ParseCreateTableQuery(queryCreateTable);
            string[] qualifiedTableNameSplit = SplitTableName(qualifiedTableName);

            qualifiedName.Database = Unquote(qualifiedTableNameSplit[0]);
            qualifiedName.Schema = Unquote(qualifiedTableNameSplit[1]);
            qualifiedName.Table = Unquote(qualifiedTableNameSplit[2]);

            return qualifiedName;
        }

        private static string ParseCreateTableQuery(string createTable)
        {
            string tableName = createTable[(createTable.IndexOf("CREATE TABLE") + "CREATE TABLE".Length)..].Trim();
            if (tableName.Contains(' ')) { tableName = tableName[..tableName.IndexOf(' ')]; }

            return tableName;
        }

        private static string[] SplitTableName(string fullTableName)
        {
            string[] resultArray = [string.Empty, string.Empty, string.Empty]; // {Database, Schema, Table}
            string[] splitArray = fullTableName.Split(".");

            for (int i = 0; i < splitArray.Length; i++)
            {
                resultArray[i] = splitArray[splitArray.Length - 1 - i];
            }

            Array.Reverse(resultArray);
            return resultArray;
        }

        #endregion

        #region COLUMNS

        public static Column[] GetColumnsFromQuery(List<string> queryColumns)
        {
            List<Column> columns = [];
            foreach (string columnDefinition in queryColumns)
            {
                Column column = new();
                string[] columnData = columnDefinition.Split(' ');
                
                column.Name = InputQueryColumn.GetColumnName(columnData[0]);
                (column.TypeSql, column.TypeNet) = InputQueryColumn.GetColumnType(columnData[1]);
                column.SizeSql = InputQueryColumn.GetColumnSize(columnData[1]);
                column.Nullable = InputQueryColumn.GetColumnNullable(columnDefinition);
                column.Primary = InputQueryColumn.GetColumnPrimary(columnDefinition);
                column.Identity = InputQueryColumn.GetColumnIdentity(columnDefinition);
                column.Enabled = true;

                columns.Add(column);
            }
            return columns.ToArray();
        }

        #endregion

        #region HELPERS

        public static string Unquote(string s)
        {
            if (s.Length >= 2 && (s[0] == '(' && s[^1] == ')' || s[0] == '[' && s[^1] == ']' || s[0] == '"' && s[^1] == '"' || s[0] == '`' && s[^1] == '`')) { return s[1..^1]; }
            return s;
        }

        #endregion
    }
}
