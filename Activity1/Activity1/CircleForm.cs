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
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();
            obj1.StartPosition = FormStartPosition.CenterScreen;
            obj1.Show();

            Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double inputCircle = double.Parse(txtCircle.Text);
            double result = 3.141592653589793238462643383279502884197 * inputCircle * inputCircle;

            lblOutput.Text = result.ToString();
        }
    }
}
