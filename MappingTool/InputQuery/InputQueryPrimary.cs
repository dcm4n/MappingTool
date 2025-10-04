using System;

namespace MappingTool.Input
{
    internal static class InputQueryPrimary
    {
        //private void SetTablePrimary(Query queryCreateTable)
        //{
        //    string[] alterTablePrimaryColumns = GetPrimaryColumnsFromAlterTable(queryCreateTable.AlterQuery);

        //    foreach (string columnName in alterTablePrimaryColumns)
        //    {
        //        foreach (Column column in columns)
        //        {
        //            if (column.RawQuery.Contains("PRIMARY", StringComparison.InvariantCultureIgnoreCase)) { column.Primary = true;  }   // Inline primary
        //            if (column.Name == columnName) { column.Primary = true; }                                                           // ALTER TABLE primary
        //        }
        //    }
        //}

        //private static string[] GetPrimaryColumnsFromAlterTable(List<string> alterTableStatements)
        //{
        //    string[] alterTablePrimaryColumns = [];

        //    foreach (string alterTable in alterTableStatements)
        //    {
        //        if (alterTable.Contains("PRIMARY", StringComparison.InvariantCultureIgnoreCase))
        //        {
        //            int columnNamesStart = alterTable.IndexOf('(');
        //            int columnNamesEnd = alterTable.IndexOf(')');

        //            alterTablePrimaryColumns = alterTable[columnNamesStart..columnNamesEnd].Split(',');
        //        }
        //    }
        //    return alterTablePrimaryColumns;
        //}
    }
}
