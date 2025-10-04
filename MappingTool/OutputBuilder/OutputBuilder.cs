using System;
using MappingTool.Objects;
using System.Reflection;

namespace MappingTool.Output
{
    public class OutputBuilder
    {
        #region CONSTANTS

        private const string columnsTemplatePath = "MappingTool.OutputBuilder.Templates.Columns.sbn";
        private const string privateMembersTemplatePath = "MappingTool.OutputBuilder.Templates.PrivateMembers.sbn";
        private const string publicPropertiesTemplatePath = "MappingTool.OutputBuilder.Templates.PublicProperties.sbn";
        private const string selectAllTemplatePath = "MappingTool.OutputBuilder.Templates.SelectAll.sbn";

        // --

        private const string classHeaderTemplatePath = "MappingTool.OutputBuilder.Templates.ClassHeader.sbn";
        private const string classBodyTemplatePath = "MappingTool.OutputBuilder.Templates.ClassBody.sbn";     
        private const string classBodyNamespaceTemplatePath = "MappingTool.OutputBuilder.Templates.ClassBodyNamespace.sbn";
        private const string classTemplatePath = "MappingTool.OutputBuilder.Templates.Class.sbn";

        #endregion

        #region PRIVATE MEMBERS

        private readonly Class tableClass;
        private readonly string result;

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

        private readonly Scriban.Template classHeaderTemplate = GetTemplate(classHeaderTemplatePath);
        private readonly object classHeaderModel;
        private readonly string classHeaderString;

        private readonly Scriban.Template classBodyTemplate = GetTemplate(classBodyTemplatePath);
        private readonly object classBodyModel;
        private readonly string classBodyString;

        private readonly Scriban.Template classBodyNamepsaceTemplate = GetTemplate(classBodyNamespaceTemplatePath);
        private readonly object? classBodyNamespaceModel;
        private readonly string? classBodyNamespaceString;

        private readonly Scriban.Template classTemplate = GetTemplate(classTemplatePath);
        private readonly object classModel;

        #endregion

        public string Result => result;

        public OutputBuilder(Class tableClass) 
        {
            this.tableClass = tableClass;

            columnsModel = GetColumnsModel();
            columnsString = columnsTemplate.Render(columnsModel);

            privateMembersModel = GetPrivateMembersModel();
            privateMembersString = privateMembersTemplate.Render(privateMembersModel);

            publicPropertiesModel = GetPublicPropertiesModel();
            publicPropertiesString = publicPropertiesTemplate.Render(publicPropertiesModel);

            selectAllModel = GetSelectAllModel();
            selectAllString = selectAllTemplate.Render(selectAllModel);

            // --

            classHeaderModel = GetClassHeaderModel();
            classHeaderString = classHeaderTemplate.Render(classHeaderModel);

            classBodyModel = GetClassBodyModel();
            classBodyString = classBodyTemplate.Render(classBodyModel);

            if (tableClass.UseNamespace)
            {
                classBodyNamespaceModel = GetClassBodyNamespaceModel();
                classBodyNamespaceString = classBodyNamepsaceTemplate.Render(classBodyNamespaceModel);
            }

            classModel = GetClassModel();
            result = classTemplate.Render(classModel);
        }

        #region CLASS MODEL

        private object GetClassHeaderModel()
        {
            object data = new
            {
                usings = new List<String> { "System.Data", "Microsoft.Data.SqlClient" },
                date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                className = tableClass.Name,
            };
            return data;
        }

        private object GetClassBodyModel()
        {
            object data = new
            {
                className = tableClass.Name,
                columns = columnsString,
                privateMembers = privateMembersString,
                publicProperties = publicPropertiesString,
                selectAll = selectAllString,
            };
            return data;
        }

        private object GetClassBodyNamespaceModel()
        {
            object data = new
            {
                classNamespace = tableClass.Namespace,
                classBody = classBodyString
            };
            return data;
        }


        private object GetClassModel()
        {
            string classBody;
            if (tableClass.UseNamespace) { classBody = classBodyNamespaceString; }
            else { classBody = classBodyString; }

            object data = new
            {
                classHeader = classHeaderString,
                classBody = classBody
            };
            return data;
        }

        #endregion

        #region COLUMNS

        private object GetColumnsModel()
        {
            List<object> columns = [];
            foreach (KeyValuePair<string, Column> column in tableClass.Table.Columns)
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
            foreach (KeyValuePair<string, Column> column in tableClass.Table.Columns)
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
            foreach (KeyValuePair<string, Column> column in tableClass.Table.Columns)
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
            foreach (KeyValuePair<string, Column> column in tableClass.Table.Columns)
            {
                columns.Add(new { name = column.Value.Name });
            }
            return new { tableName = tableClass.Table.QualifiedName.Table, columns };
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
