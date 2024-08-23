using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07PETAGuessingWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("c??????r");
            lblGuess.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList answers = new ArrayList();
            answers.Add("computer");

            string wordGuess = txtGuessLine.Text.ToLower();

            if (answers.Contains(wordGuess) && wordGuess.Equals("computer")) 
            {
                lblGuess.Text = wordGuess;
                txtGuessLine.Text = "";
                string message = "Correct Guess";
                MessageBox.Show(message, null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                if (string.IsNullOrEmpty(txtGuessLine.Text)) return;
                listBox1.Items.Add(txtGuessLine.Text);
                string message = "Wrong Guess\nTry Again";
                MessageBox.Show(message, null, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}