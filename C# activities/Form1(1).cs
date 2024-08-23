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

namespace _06HandsOn1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBoxFunc();

        }

        public void ComboBoxFunc()
        {
            ArrayList programs = new ArrayList();

            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");

            for(int i = 0; i < programs.Count; i++)
            {
                comboProgram.Items.Add(programs[i]);
            }

            for (int day = 1; day <= 31; day++)
            {
                comboDay.Items.Add(day);
            }
            for (int month = 1; month <= 12; month++)
            {
                comboMonth.Items.Add(month);
            }
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                comboYear.Items.Add(year);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            string LastName = txtlastName.Text;
            string FirstName = txtFirstname.Text;
            string MiddleName = txtMidname.Text;
            string gender = rMale.Checked ? "Male" : "Female";
            string day = comboDay.SelectedItem.ToString();
            string month = comboMonth.SelectedItem.ToString();
            string year = comboYear.SelectedItem.ToString();
            string program = comboProgram.SelectedItem.ToString();

            string message = $"Student Information:\n\nName: {FirstName} {MiddleName} {LastName} \nGender: {gender}\nDate of Birth: {month}/{day}/{year} \nProgram: {program}";

            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}