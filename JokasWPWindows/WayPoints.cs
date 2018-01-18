using Parse;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace JokasWPWindows
{
    class WayPoints
    {
        public async void GetWaypointsAsync(DataGridView grid, string projectID, string projectName="N/A")
        {
            System.Data.DataTable table = new DataTable("WaypointTable");
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
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "latitude";
            column.AutoIncrement = false;
            column.Caption = "latitude";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);
            // Create third column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "longitude";
            column.AutoIncrement = false;
            column.Caption = "longitude";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            // Create forth column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "createdat";
            column.AutoIncrement = false;
            column.Caption = "createdat";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);
            // Create fifth  column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "projectname";
            column.AutoIncrement = false;
            column.Caption = "projectname";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);


            DataSet ds = new DataSet();
            ds.Tables.Add(table);

            ParseQuery<Parse.ParseObject> query = ParseObject.GetQuery("waypoints");
            query.WhereEqualTo("id", projectID);
            IEnumerable<ParseObject> projects = await query.FindAsync();

            foreach (ParseObject project in projects)
            {
                double dLat = project.Get<double>("latitude");
                double dLong = project.Get<double>("longitude");
                System.DateTime dCreatedAt = project.CreatedAt.Value;
                row = table.NewRow();
                row["id"] = project.ObjectId;
                row["latitude"] = dLat;
                row["longitude"] = dLong;
                row["createdat"] = dCreatedAt;
                row["projectname"] = projectName;
                Debug.WriteLine("Project: " + dLat);
                table.Rows.Add(row);
            }
            grid.DataSource = ds.Tables[0];
            
            grid.Columns["id"].HeaderText = "ProjectID";
            grid.Columns["id"].Visible = false;
            grid.Columns["latitude"].HeaderText = "Lattitud";
            grid.Columns["longitude"].HeaderText = "Longitud";
            grid.Columns["createdat"].HeaderText = "Datum/Tid";
            grid.Columns["projectname"].HeaderText = "Projekt namn";
            grid.Columns["projectname"].DisplayIndex = 0;


        }
        public async void GetWaypointsAsync(System.IO.StreamWriter objWriter, string projectID, string delimiter=",")
        {
            ParseQuery<Parse.ParseObject> query = ParseObject.GetQuery("waypoints");
            query.WhereEqualTo("id", projectID);
            IEnumerable<ParseObject> projects = await query.FindAsync();

            foreach (ParseObject project in projects)
            {
               
                double dLat = project.Get<double>("latitude");
                double dLong = project.Get<double>("longitude");
                objWriter.WriteLine(dLong.ToString().Replace(",",".") + delimiter + dLat.ToString().Replace(",", "."));
                Debug.WriteLine("Project: " + dLat);
            }
            objWriter.Close();


        }
    }
}
   

