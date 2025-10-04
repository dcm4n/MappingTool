using System;
using System.Data;

namespace MappingTool.Input
{
    internal static class InputQueryColumn
    {

        #region NAME

        public static string GetColumnName(string queryColumnName)
        {
            string name = Unquote(queryColumnName);
            return name;
        }

        #endregion

        #region TYPE

        // https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
        public static (SqlDbType, Type) GetColumnType(string queryColumnType)
        {
            SqlDbType typeSql = SqlDbType.VarChar;
            Type typeNet = typeof(string);
            
            string typeSqlQuery;
            if (queryColumnType.Contains('(')) { typeSqlQuery = Unquote(queryColumnType[..queryColumnType.IndexOf('(')].Trim()); }
            else { typeSqlQuery = Unquote(queryColumnType.Trim()); }

            switch (typeSqlQuery.ToLower().Trim())
            {
                case ("bit"):
                    typeSql = SqlDbType.Bit;
                    typeNet = typeof(bool);
                    break;
                case ("tynint"):
                    typeSql = SqlDbType.TinyInt;
                    typeNet = typeof(byte);
                    break;
                case ("smallint"):
                    typeSql = SqlDbType.SmallInt;
                    typeNet = typeof(short);
                    break;
                case ("int"):
                    typeSql = SqlDbType.Int;
                    typeNet = typeof(int);
                    break;
                case ("bigint"):
                    typeSql = SqlDbType.BigInt;
                    typeNet = typeof(long);
                    break;
                case ("decimal"):
                    typeSql = SqlDbType.Decimal;
                    typeNet = typeof(decimal);
                    break;
                case ("real"):
                    typeSql = SqlDbType.Real;
                    typeNet = typeof(Single);
                    break;
                case ("float"):
                    typeSql = SqlDbType.Float;
                    typeNet = typeof(double);
                    break;
                case ("char"):
                    typeSql = SqlDbType.Char;
                    typeNet = typeof(string);
                    break;
                case ("varchar"):
                    typeSql = SqlDbType.VarChar;
                    typeNet = typeof(string);
                    break;
                case ("nchar"):
                    typeSql = SqlDbType.NChar;
                    typeNet = typeof(string);
                    break;
                case ("nvarchar"):
                    typeSql = SqlDbType.NVarChar;
                    typeNet = typeof(string);
                    break;
                case ("binary"):
                    typeSql = SqlDbType.Binary;
                    typeNet = typeof(Byte[]);
                    break;
                case ("varbinary"):
                    typeSql = SqlDbType.VarBinary;
                    typeNet = typeof(Byte[]);
                    break;
                case ("uniqueidentifier"):
                    typeSql = SqlDbType.UniqueIdentifier;
                    typeNet = typeof(Guid);
                    break;
                case ("date"):
                    typeSql = SqlDbType.Date;
                    typeNet = typeof(DateTime);
                    break;
                case ("time"):
                    typeSql = SqlDbType.Time;
                    typeNet = typeof(TimeSpan);
                    break;
                case ("datetime"):
                    typeSql = SqlDbType.DateTime;
                    typeNet = typeof(DateTime);
                    break;
                case ("smalldatetime"):
                    typeSql = SqlDbType.SmallDateTime;
                    typeNet = typeof(DateTime);
                    break;
                case ("datetime2"):
                    typeSql = SqlDbType.DateTime;
                    typeNet = typeof(DateTime);
                    break;
                case ("datetimeoffset"):
                    typeSql = SqlDbType.DateTimeOffset;
                    typeNet = typeof(DateTimeOffset);
                    break;
                case ("xml"):
                    typeSql = SqlDbType.Xml;
                    typeNet = typeof(string);
                    break;
                case ("numeric"):
                    typeSql = SqlDbType.Decimal;
                    typeNet = typeof(decimal);
                    break;
                case ("text"):
                    typeSql = SqlDbType.Text;
                    typeNet = typeof(string);
                    break;
                case ("image"):
                    typeSql = SqlDbType.Image;
                    typeNet = typeof(Byte[]);
                    break;
                case ("rowversion"):
                    typeSql = SqlDbType.Binary; // guess
                    typeNet = typeof(Byte);
                    break;
                case ("timestamp"):
                    typeSql = SqlDbType.Timestamp;
                    typeNet = typeof(Byte[]);
                    break;
                case ("sqlvariant"):
                    typeSql = SqlDbType.Variant;
                    typeNet = typeof(object);
                    break;
                default:

                    if (typeSqlQuery.Contains("numeric")) { }
                    if (typeSqlQuery.Contains("text")) { }
                    if (typeSqlQuery.Contains("image")) { }
                    if (typeSqlQuery.Contains("rowversion")) { }
                    if (typeSqlQuery.Contains("timestamp")) { }
                    if (typeSqlQuery.Contains("sqlvariant")) { }
                    break;
            }
            return (typeSql, typeNet);
        }

        public static int GetColumnSize(string queryColumnType)
        {
            int sizeSql;
            string sizeSqlQuery;

            if (queryColumnType.Contains('(')) { sizeSqlQuery = Unquote((queryColumnType[queryColumnType.IndexOf('(')..]).Trim(',').Trim()); }
            else { sizeSqlQuery = "0"; }

            sizeSql = (sizeSqlQuery == "MAX") ? -1 : int.Parse(sizeSqlQuery);
            return sizeSql;
        }

        #endregion

        #region NULLABLE

        public static bool GetColumnNullable(string columnDefinition)
        {
            if (columnDefinition.Contains("NOT NULL")) { return false; }
            else { return true; }
        }

        #endregion

        #region PRIMARY KEY

        public static bool GetColumnPrimary(string columnDefinition)
        {
            if (columnDefinition.Contains("PRIMARY")) { return true; }
            else { return false; }
        }

        #endregion

        #region IDENTITY

        public static bool GetColumnIdentity(string columnDefinition)
        {
            if (columnDefinition.Contains("IDENTITY")) { return true; }
            else { return false; }
        }

        #endregion

        #region HELPERS

        private static string Unquote(string s)
        {
            if (s.Length >= 2 && (s[0] == '(' && s[^1] == ')' || s[0] == '[' && s[^1] == ']' || s[0] == '"' && s[^1] == '"' || s[0] == '`' && s[^1] == '`')) { return s[1..^1]; }
            return s;
        }

        #endregion
    }
}
