using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1_0905
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount.Text);
            string value1 = "";
            string value2 = "";
            //string value3 = "";

            int tens = amount / 10;
            int ones = amount - (tens * 10);

            if(amount >= 11 || amount <= 19)
            {
                switch(amount)
                {
                    case 11:
                        value1 = "Eleven";
                        break;
                    case 12:
                        value1 = "Twelve";
                        break;
                    case 13:
                        value1 = "Thirteen";
                        break;
                    case 14:
                        value1 = "Fourteen";
                        break;
                    case 15:
                        value1 = "Fifteen";
                        break;
                    case 16:
                        value1 = "Sixteen";
                        break;
                    case 17:
                        value1 = "Seventeen";
                        break;
                    case 18:
                        value1 = "Eighteen";
                        break;
                    case 19:
                        value1 = "Nineteen";
                        break;
                    
                }
            } else
            {
                switch(tens)
                {
                    // Tens
                    case 1:
                        value2 = "Ten";
                        break;
                    case 2:
                        value2 = "Twenty";
                        break;
                    case 3:
                        value2 = "Thirty";
                        break;
                    case 4:
                        value2 = "Forty";
                        break;
                    case 5:
                        value2 = "Fifthy";
                        break;
                    case 6:
                        value2 = "Sixthy";
                        break;
                    case 7:
                        value2 = "Seventhy";
                        break;
                    case 8:
                        value2 = "Eighthy";
                        break;
                    case 9:
                        value2 = "Ninety";
                        break;
                    
                }

                switch (ones)
                {
                    // Ones
                    case 1:
                        value1 = "Ten";
                        break;
                    case 2:
                        value1 = "Twenty";
                        break;
                    case 3:
                        value1 = "Thirty";
                        break;
                    case 4:
                        value1 = "Forty";
                        break;
                    case 5:
                        value1 = "Fifthy";
                        break;
                    case 6:
                        value1 = "Sixthy";
                        break;
                    case 7:
                        value1 = "Seventhy";
                        break;
                    case 8:
                        value1 = "Eighthy";
                        break;
                    case 9:
                        value1 = "Ninety";
                        break;
                    
                }

            }
            

            output.Text = value2 + " " + value1;
        }
    }
}
