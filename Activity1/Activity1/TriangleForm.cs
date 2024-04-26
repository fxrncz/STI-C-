using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();

            Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double inputBase = double.Parse(txtBase.Text);
            double inputHeight = double.Parse(txtHeight.Text);

            double result = (inputBase * inputHeight) / 2;
            lblOutput.Text = result.ToString();
        }
    }
}
