using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeApplication.EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string firstName = txtFN.Text;
            string lastName = txtLN.Text;
            string dept = txtDept.Text;
            string jobTitle = txtJob.Text;
            double ratePH = Convert.ToDouble(txtRPH.Text);
            int workHrs = Convert.ToInt32(txtHW.Text);

            PartTimeEmployee obj = new PartTimeEmployee(firstName, lastName, dept, jobTitle);
            obj.computeSalary(workHrs, ratePH);

            opFN.Text = obj.FirstName;
            opLN.Text = obj.LastName;
            opSalary.Text = obj.getSalary().ToString();
        }
    }
}
