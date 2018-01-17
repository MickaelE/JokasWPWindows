using Parse;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace JokasWPWindows
{
    class Projects
    {
        public async void GetProjectsAsync(ComboBox box)
        {
            System.Data.DataTable table = new DataTable("ProjectTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "project_name";
            column.AutoIncrement = false;
            column.Caption = "project_name";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            DataSet ds = new DataSet();
            ds.Tables.Add(table);

            ParseQuery<ParseObject> query = ParseObject.GetQuery("project");
            IEnumerable<ParseObject> projects = await query.FindAsync();

            foreach (ParseObject project in projects)
            {
                string name = project.Get<string>("project_name");
                row = table.NewRow();
                row["id"] = project.ObjectId;
                row["project_name"] = name;
                table.Rows.Add(row);
             Debug.WriteLine("Project: " + name);
            }
            box.DataSource= ds.Tables[0];
            box.ValueMember = "id";
            box.DisplayMember = "project_name";
        }
    }
}
