using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decisionmaking04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            String givenName = txtName.Text;

            double inputEnglish = double.Parse(txtEnglish.Text);
            double inputMath = double.Parse(txtMath.Text);
            double inputScience = double.Parse(textBox3.Text);
            double inputFilipino = double.Parse(txtFilipino.Text);
            double inputHistory = double.Parse(txtHistory.Text);

            double gradeAverage = (inputEnglish + inputMath + inputScience + inputFilipino + inputHistory) / 5;

            if(gradeAverage >= 75)
            {
                String result = "The student passed!" + Environment.NewLine + "The General Average of " + givenName + " is " + gradeAverage;
                lblOutput.Text = result;
            } else
            {
                String result = "The student failed!" + Environment.NewLine + "The General Average of " + givenName + " is " + gradeAverage;
                lblOutput.Text = result;
            }
            
        }
    }
}
