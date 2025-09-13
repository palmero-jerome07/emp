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
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "SELECT * FROM [tblEmployee] WHERE [EmployeeID] = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);
            if (dtg_addrequestor == true)
            {
                MessageBox.Show("This account '" + txtRequestorName.Text + "' is already exist.", "Not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";
            }
            else
            {
                string add_requestor = "INSERT INTO [tblEmployeeData] (" +
                    "[EmployeeNumber], " +
                    "[RequestorName], " +
                    "[RequestorEmail], " +
                    "[Section], " +
                    "[LocalNumber]) VALUES " +
                    "('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";
            }
        }
    }
}
