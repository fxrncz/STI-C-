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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();

            Visible = false;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            SquareForm sq = new SquareForm();
            sq.StartPosition = FormStartPosition.CenterScreen;
            sq.Show();

            Visible=false;
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            RectForm rect = new RectForm();
            rect.StartPosition = FormStartPosition.CenterScreen;
            rect.Show();

            Visible = false;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            CircleForm cf = new CircleForm();
            cf.StartPosition = FormStartPosition.CenterScreen;
            cf.Show();

            Visible = false;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            TriangleForm tf = new TriangleForm();
            tf.StartPosition = FormStartPosition.CenterScreen;
            tf.Show();

            Visible = false;
        }
    }
}
