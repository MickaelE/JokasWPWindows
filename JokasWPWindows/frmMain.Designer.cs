namespace JokasWPWindows
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.projectCombo = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.wayPointsDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wayPointsDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectCombo
            // 
            this.projectCombo.FormattingEnabled = true;
            this.projectCombo.Location = new System.Drawing.Point(4, 16);
            this.projectCombo.Margin = new System.Windows.Forms.Padding(1);
            this.projectCombo.Name = "projectCombo";
            this.projectCombo.Size = new System.Drawing.Size(133, 21);
            this.projectCombo.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(151, 10);
            this.btnShow.Margin = new System.Windows.Forms.Padding(1);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 26);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Visa";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // wayPointsDataGrid
            // 
            this.wayPointsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wayPointsDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wayPointsDataGrid.Location = new System.Drawing.Point(0, 69);
            this.wayPointsDataGrid.Margin = new System.Windows.Forms.Padding(1);
            this.wayPointsDataGrid.Name = "wayPointsDataGrid";
            this.wayPointsDataGrid.RowTemplate.Height = 40;
            this.wayPointsDataGrid.Size = new System.Drawing.Size(629, 292);
            this.wayPointsDataGrid.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bExport);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.projectCombo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(629, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projekt";
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(151, 37);
            this.bExport.Margin = new System.Windows.Forms.Padding(1);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(93, 28);
            this.bExport.TabIndex = 3;
            this.bExport.Text = "Exportera";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wayPointsDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmMain";
            this.Text = "JokasWpWindows";
            ((System.ComponentModel.ISupportInitialize)(this.wayPointsDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox projectCombo;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView wayPointsDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bExport;
    }
}

