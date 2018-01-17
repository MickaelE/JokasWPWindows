using System;
using System.Windows.Forms;

namespace JokasWPWindows
{
    public partial class frmMain : Form
    {
        Projects oProject = new Projects();
        WayPoints oWayPoints = new WayPoints();
        public frmMain()
        {
            InitializeComponent();
            oProject.GetProjectsAsync(projectCombo);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            oWayPoints.GetWaypointsAsync(wayPointsDataGrid, projectCombo.SelectedValue.ToString());
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            string file_name = "test1.txt";
           
            
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    String selectedTexts = projectCombo.Text.ToLower();
                    file_name = fbd.SelectedPath +"\\" + selectedTexts + ".dxf";
                    var objWriter = new System.IO.StreamWriter(file_name);
                    oWayPoints.GetWaypointsAsync(objWriter, projectCombo.SelectedValue.ToString());
        }
            }
        }
    }
}
