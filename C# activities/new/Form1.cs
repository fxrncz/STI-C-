using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace StudentResignation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxes();
        }
        private void PopulateComboBoxes()
        {
            for (int day = 1; day <= 31; day++)
            {
                chooseDay.Items.Add(day);
            }
            for (int month = 1; month <= 12; month++)
            {
                chooseMonth.Items.Add(month);
            }
            int currentYear = DateTime.Now.Year;
            for (int year = 1900; year <= currentYear; year++)
            {
                chooseYear.Items.Add(year);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LastName = txtlastName.Text;
            string FirstName = txtfirstName.Text;
            string MiddleName = txmiddleName.Text;
            string gender = rboxMale.Checked ? "Male" : "Female";
            string day = chooseDay.SelectedItem.ToString();
            string month = chooseMonth.SelectedItem.ToString();
            string year = chooseYear.SelectedItem.ToString();

            string message = $"Student Information:\n\nName: {FirstName} {MiddleName} {LastName} \nGender: {gender}\nDate of Birth: {month}/{day}/{year}";

            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}