using MappingTool.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MappingTool.Parser
{
    internal static class QueryTable
    {
        #region TABLE NAME

        public static QualifiedName GetQualifiedName(string queryCreateTable)
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

        public static Dictionary<string, Column> GetColumns(List<string> queryColumns)
        {
            Dictionary<string, Column> columns = [];
            foreach (string columnDefinition in queryColumns)
            {
                string[] columnData = columnDefinition.Split(' ');
                Column column = new();

                column.Name = QueryColumn.GetColumnName(columnData[0]);
                (column.TypeSql, column.TypeNet) = QueryColumn.GetColumnType(columnData[1]);
                column.SizeSql = QueryColumn.GetColumnSize(columnData[1]);
                column.Nullable = QueryColumn.GetColumnNullable(columnDefinition);
                column.Primary = QueryColumn.GetColumnPrimary(columnDefinition);
                column.Identity = QueryColumn.GetColumnIdentity(columnDefinition);
                column.Enabled = true;

                columns[column.Name] = column;
            }
            return columns;
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
