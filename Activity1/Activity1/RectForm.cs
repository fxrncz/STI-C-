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
    public partial class RectForm : Form
    {
        public RectForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double inputWidth = double.Parse(txtWidth.Text);
            double inputLength = double.Parse(txtLength.Text);

            double result = inputLength * inputWidth;

            lblOutput.Text = result.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();
            obj1.StartPosition = FormStartPosition.CenterScreen;
            obj1.Show();

            Visible = false;
        }
    }
}
