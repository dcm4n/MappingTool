using System;
using System.Text.RegularExpressions;

namespace MappingTool.Parser
{
    public class Query
    {
        #region PRIVATE MEMBERS

        private readonly string rawQuery = string.Empty;
        private readonly string parsedQuery = string.Empty;
        private string tableNameQuery = string.Empty;
        private readonly List<string> tableColumnQueries = [];
        private string tableAsQuery = string.Empty;
        private string tableOnQuery = string.Empty;
        private readonly List<string> tableAlterQueries = [];

        #endregion

        #region PUBLIC PROPERTIES

        public string RawQuery { get => rawQuery; }
        public string ParsedQuery { get => parsedQuery; }
        public string TableNameQuery { get => tableNameQuery; }
        public List<string> ColumnQueries { get => tableColumnQueries; }
        public string AsQuery { get => tableAsQuery; }
        public string OnQuery { get => tableOnQuery; }

        public List<string> AlterQueries { get => tableAlterQueries; }

        #endregion

        public Query(string query)
        {
            if (!ValidateQuery(query))
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            rawQuery = ProcessQuery(query);
            parsedQuery = ParseQuery();

        }

        #region VALIDATION

        private static bool ValidateQuery(string query)
        {
            try
            {
                if (query.Length <= 0) { return false; }
                if (!query.Contains("CREATE TABLE", StringComparison.InvariantCultureIgnoreCase)) { return false; }
            }
            catch { return false; }
            return true;
        }

        #endregion

        #region PROCESS

        private static string ProcessQuery(string query)
        {
            string proccesedQuery = query.Replace('\n', ' ');
            return proccesedQuery;
        }

        #endregion

        #region PARSE

        public string ParseQuery()
        {
            string parsedQuery = string.Empty;
            int currentPos;
            int posStartAs;
            int posStartOn;
            int posStartAlterTable;
       
            // CREATE TABLE <table_name>
            int posStartCreateTable = rawQuery.IndexOf("CREATE TABLE", StringComparison.InvariantCultureIgnoreCase);
            string createTable = rawQuery[posStartCreateTable..rawQuery.IndexOf('(')].Trim();
            createTable = createTable.Replace("CREATE TABLE", "CREATE TABLE", StringComparison.InvariantCultureIgnoreCase);
            createTable = createTable.Replace("IF NOT EXISTS", "", StringComparison.InvariantCultureIgnoreCase);
            tableNameQuery = createTable;
            parsedQuery += createTable;

            // (
            parsedQuery = AppendNewLine(parsedQuery, "(");

            // Columns
            bool isEnclosed = false;
            bool parenthesis = false;
            bool brackets = false;
            bool quote = false;
            bool doublequote = false;

            int posStartCurrentColumn = rawQuery.IndexOf('(') + 1;
            int lengthCurrentColumn = 0;
            for (currentPos = posStartCurrentColumn; currentPos < rawQuery.Length; currentPos++)
            {
                char character = rawQuery[currentPos];

                //  Last column + )
                if (!isEnclosed && character == ')')
                {
                    string lastElement = rawQuery.Substring(posStartCurrentColumn, lengthCurrentColumn).Trim();
                    if (IsColumn(lastElement)) 
                    { 
                        tableColumnQueries.Add(lastElement); 
                    }

                    parsedQuery = AppendNewLineWithTab(parsedQuery, lastElement.Trim(','));
                    parsedQuery = AppendNewLine(parsedQuery, ")");
                    break;
                }

                // isEnclosed?
                if (character == '(' || character == ')') { parenthesis = !parenthesis; }
                if (character == '[' || character == ']') { brackets = !brackets; }
                if (character == '\'') { quote = !quote; }
                if (character == '"') { doublequote = !doublequote; }
                isEnclosed = parenthesis || brackets || quote || doublequote;

                // Current column
                if (!isEnclosed && character == ',')
                {
                    string currentElement = rawQuery.Substring(posStartCurrentColumn, lengthCurrentColumn + 1).Trim();
                    tableColumnQueries.Add(currentElement);
                    parsedQuery = AppendNewLineWithTab(parsedQuery, currentElement);
                    posStartCurrentColumn = currentPos + 1;
                    lengthCurrentColumn = 0;
                }
                else
                {
                    lengthCurrentColumn++;
                }
            }

            posStartAlterTable = rawQuery[currentPos..].Trim().IndexOf("ALTER TABLE", StringComparison.InvariantCultureIgnoreCase);
            posStartAlterTable = posStartAlterTable > 0 ? currentPos + posStartAlterTable : rawQuery.Length - 1;

            posStartAs = rawQuery[currentPos..posStartAlterTable].Trim().IndexOf("AS", StringComparison.InvariantCultureIgnoreCase);
            posStartOn = rawQuery[currentPos..posStartAlterTable].Trim().IndexOf("ON", StringComparison.InvariantCultureIgnoreCase);
            
            // AS
            if (posStartAs > 0) 
            {
                int posEndAs = rawQuery.Length - 1;
                if (posStartAlterTable > 0) { posEndAs = posStartAlterTable; }
                if (posStartOn > 0) { posEndAs = posStartOn; }

                tableAsQuery = rawQuery[(currentPos + posStartAs)..(currentPos + posEndAs)].Trim();
                parsedQuery = AppendNewLine(parsedQuery, tableAsQuery);
            }

            // ON
            if (posStartOn > 0)
            {
                int PosEndOn = rawQuery.Length - 1;
                if (posStartAlterTable > 0) { PosEndOn = posStartAlterTable; }

                tableOnQuery = rawQuery[(currentPos + posStartOn)..(currentPos + PosEndOn)].Trim();
                parsedQuery = AppendNewLine(parsedQuery, tableOnQuery);
            }

            // ALTER TABLE   
            if (posStartAlterTable > 0)
            {
                string alterTables = rawQuery[posStartAlterTable..].Trim();
                string[] alterTableSplit = Regex.Split(alterTables, "ALTER TABLE", RegexOptions.IgnoreCase);
                foreach (string alterTable in alterTableSplit)
                {
                    if (alterTable.Trim().Length > 0)
                    {
                        tableAlterQueries.Add("ALTER TABLE" + alterTable);
                        parsedQuery = AppendNewLine(parsedQuery, "ALTER TABLE" + alterTable);
                    }
                }
            }

            return parsedQuery;
        }

        #endregion

        #region HELPERS

        // https://learn.microsoft.com/en-us/sql/t-sql/statements/create-table-transact-sql?view=sql-server-ver17#full-syntax
        public static bool IsColumn(string columnDefinition)
        {
            columnDefinition = columnDefinition.Trim();
            if (columnDefinition.StartsWith("ON", StringComparison.InvariantCultureIgnoreCase)) { return false; }                                                                               // ON ...
            if (columnDefinition[(columnDefinition.IndexOf(' ') + 1)..].StartsWith("AS", StringComparison.InvariantCultureIgnoreCase)) { return false; }                                        // <computed_column_definition>
            if (columnDefinition[(columnDefinition.IndexOf(' ') + 1)..].StartsWith("XML COLUMN_SET FOR ALL_SPARSE_COLUMNS", StringComparison.InvariantCultureIgnoreCase)) { return false; }     // <column_set_definition>
            if (columnDefinition.StartsWith("CONSTRAINT", StringComparison.InvariantCultureIgnoreCase)) { return false; }                                                                       // <table_constraint>
            if (columnDefinition.StartsWith("INDEX", StringComparison.InvariantCultureIgnoreCase)) { return false; }                                                                            // <table_index>
            return true;
        }

        private static string AppendNewLine(string text, string  newLine)
        {
            return text += Environment.NewLine + newLine.Trim();
        }

        private static string AppendNewLineWithTab(string text, string newLine)
        {
            return text += Environment.NewLine + "\t" + newLine.Trim();
        }

        #endregion
    }
}
