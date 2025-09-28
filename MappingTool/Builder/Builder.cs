using MappingTool.Objects;
using System.Data;
using System.Reflection;

namespace MappingTool.Builder
{
    public class Builder
    {
        #region CONSTANTS

        private const string columnsTemplatePath = "MappingTool.Builder.Templates.Columns.sbn";
        private const string privateMembersTemplatePath = "MappingTool.Builder.Templates.PrivateMembers.sbn";
        private const string publicPropertiesTemplatePath = "MappingTool.Builder.Templates.PublicProperties.sbn";
        private const string selectAllTemplatePath = "MappingTool.Builder.Templates.SelectAll.sbn";

        // --

        private const string classTemplatePath = "MappingTool.Builder.Templates.Class.sbn";

        #endregion

        #region PRIVATE MEMBERS

        private readonly Table table;

        private readonly Scriban.Template columnsTemplate = GetTemplate(columnsTemplatePath);
        private readonly object columnsModel;
        private readonly string columnsString;

        private readonly Scriban.Template privateMembersTemplate = GetTemplate(privateMembersTemplatePath);
        private readonly object privateMembersModel;
        private readonly string privateMembersString;

        private readonly Scriban.Template publicPropertiesTemplate = GetTemplate(publicPropertiesTemplatePath);
        private readonly object publicPropertiesModel;
        private readonly string publicPropertiesString;

        private readonly Scriban.Template selectAllTemplate = GetTemplate(selectAllTemplatePath);
        private readonly object selectAllModel;
        private readonly string selectAllString;

        // --

        private readonly Scriban.Template classTemplate = GetTemplate(classTemplatePath);
        private readonly object classModel;

        #endregion

        public Builder(Table tableObject) 
        { 
            table = tableObject;

            columnsModel = GetColumnsModel();
            columnsString = columnsTemplate.Render(columnsModel);

            privateMembersModel = GetPrivateMembersModel();
            privateMembersString = privateMembersTemplate.Render(privateMembersModel);

            publicPropertiesModel = GetPublicPropertiesModel();
            publicPropertiesString = publicPropertiesTemplate.Render(publicPropertiesModel);

            selectAllModel = GetSelectAllModel();
            selectAllString = selectAllTemplate.Render(selectAllModel);

            classModel = GetClassModel();
            string result = classTemplate.Render(classModel);
        }

        #region CLASS MODEL

        private object GetClassModel()
        {
            object data = new
            {
                usings = new List<String> { "System.Data", "Microsoft.Data.SqlClient" },
                date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                className = table.QualifiedName.Table,
                columns = columnsString,
                privateMembers = privateMembersString,
                publicProperties = publicPropertiesString,
                selectAll = selectAllString,
            };
            return data;
        }

        #endregion

        #region COLUMNS

        private object GetColumnsModel()
        {
            List<object> columns = [];
            foreach (KeyValuePair<string, Column> column in table.ColumnsEnabled)
            {
                columns.Add(new 
                { 
                    name = column.Value.Name, 
                    typeSql = "SqlDbType." + column.Value.TypeSql, 
                    sizeSql = column.Value.SizeSql,
                    typeNet = "typeof(" + column.Value.TypeNet.Name + ")", 
                    nullable = TocamelCaseString(column.Value.Nullable.ToString()), 
                    primary = TocamelCaseString(column.Value.Primary.ToString()), 
                    identity = TocamelCaseString(column.Value.Identity.ToString()) 
                });
            }

            return new { columns };
        }

        #endregion

        #region PRIVATE MEMBERS MODEL

        private object GetPrivateMembersModel()
        {
            List<object> privateMembers = [];
            foreach (KeyValuePair<string, Column> column in table.ColumnsEnabled)
            {
                privateMembers.Add (new{ name = TocamelCaseString(column.Value.Name), typeNet = column.Value.TypeNet.Name, nullable = column.Value.Nullable});
            }

            return new { privateMembers };
        }

        #endregion

        #region PUBLIC PROPERTIES MODEL

        private object GetPublicPropertiesModel()
        {
            List<object> publicProperties = [];
            foreach (KeyValuePair<string, Column> column in table.ColumnsEnabled)
            {
                publicProperties.Add(new { publicName = column.Value.Name, privateName = TocamelCaseString(column.Value.Name), typeNet = column.Value.TypeNet.Name, nullable = column.Value.Nullable });
            }

            return new { publicProperties };
        }

        #endregion

        #region SELECT ALL

        private object GetSelectAllModel()
        {
            List<object> columns = [];
            foreach (KeyValuePair<string, Column> column in table.ColumnsEnabled)
            {
                columns.Add(new { name = column.Value.Name });
            }
            return new { tableName = table.QualifiedName.Table, columns };
        }

        #endregion


        #region HELPERS

        private static Scriban.Template GetTemplate(string template)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using Stream stream = assembly.GetManifestResourceStream(template) ?? throw new FileNotFoundException($"Template resource not found: " + template);
            
            using StreamReader reader = new(stream);
            string templateText = reader.ReadToEnd();

            return Scriban.Template.Parse(templateText);
        }

        private static string TocamelCaseString(string str)
        {  
            return char.ToLower(str.ToString()[0]) + str.ToString()[1..];
        }

        #endregion

    }
}
