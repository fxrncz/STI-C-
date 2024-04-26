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
    public partial class SquareForm : Form
    {
        public SquareForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double inputSquare = double.Parse(txtSquare.Text);

            double result = inputSquare * inputSquare;
            opSquare.Text = result.ToString();
        }

        private void btnBacksf_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();
            obj1.StartPosition = FormStartPosition.CenterScreen;
            obj1.Show();

            Visible = false;
        }
    }
}
