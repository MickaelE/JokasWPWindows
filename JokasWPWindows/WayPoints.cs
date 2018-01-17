using Parse;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace JokasWPWindows
{
    class WayPoints
    {
        public async void GetWaypointsAsync(DataGridView grid, string projectID)
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

            DataSet ds = new DataSet();
            ds.Tables.Add(table);

            ParseQuery<Parse.ParseObject> query = ParseObject.GetQuery("waypoints");
            query.WhereEqualTo("id", projectID);
            IEnumerable<ParseObject> projects = await query.FindAsync();

            foreach (ParseObject project in projects)
            {
                double dLat = project.Get<double>("latitude");
                double dLong = project.Get<double>("longitude");
                row = table.NewRow();
                row["id"] = project.ObjectId;
                row["latitude"] = dLat;
                table.Rows.Add(row);
                row["longitude"] = dLong;
                Debug.WriteLine("Project: " + dLat);
            }
            grid.DataSource = ds.Tables[0];
            
             grid.Columns[0].HeaderText = "ProjectID";
            grid.Columns[1].HeaderText = "Lattitud";
            grid.Columns[1].HeaderText = "Longitud";


        }
        public async void GetWaypointsAsync(System.IO.StreamWriter objWriter, string projectID, string delimiter=";")
        {
            System.Data.DataTable table = new DataTable("WaypointTable");
            DataColumn column;

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

            DataSet ds = new DataSet();
            ds.Tables.Add(table);

            ParseQuery<Parse.ParseObject> query = ParseObject.GetQuery("waypoints");
            query.WhereEqualTo("id", projectID);
            IEnumerable<ParseObject> projects = await query.FindAsync();

            foreach (ParseObject project in projects)
            {
               
                double dLat = project.Get<double>("latitude");
                double dLong = project.Get<double>("longitude");
                objWriter.WriteLine(dLat + delimiter + dLong);
                Debug.WriteLine("Project: " + dLat);
            }
            objWriter.Close();


        }
    }
}
   

