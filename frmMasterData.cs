using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            //InitializeComponent();
        }

        private Panel pnlChildTitle;
        private Label lblMasterData;
        private DataGridView dtgMasterData;

        private void InitializeComponent()
        {
            pnlChildTitle = new Panel();
            dtgMasterData = new DataGridView();
            lblMasterData = new Label();
            pnlChildTitle.SuspendLayout();
            ((ISupportInitialize)dtgMasterData).BeginInit();
            SuspendLayout();
            // 
            // pnlChildTitle
            // 
            pnlChildTitle.BackColor = SystemColors.ActiveCaption;
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(748, 45);
            pnlChildTitle.TabIndex = 0;
            // 
            // dtgMasterData
            // 
            dtgMasterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMasterData.Location = new Point(0, 51);
            dtgMasterData.Name = "dtgMasterData";
            dtgMasterData.Size = new Size(748, 323);
            dtgMasterData.TabIndex = 1;
            // 
            // lblMasterData
            // 
            lblMasterData.AutoSize = true;
            lblMasterData.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasterData.Location = new Point(14, 15);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(92, 20);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "Master Data";
            lblMasterData.Click += lblMasterData_Click;
            // 
            // frmMasterData
            // 
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(748, 373);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
            Name = "frmMasterData";
            pnlChildTitle.ResumeLayout(false);
            pnlChildTitle.PerformLayout();
            ((ISupportInitialize)dtgMasterData).EndInit();
            ResumeLayout(false);
        }

        private void lblMasterData_Click(object sender, EventArgs e)
        {

        }
    }
}
