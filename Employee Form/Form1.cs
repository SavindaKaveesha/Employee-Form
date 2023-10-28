using System.Windows.Forms;

namespace Employee_Form
{
    public partial class Form1 : Form
    {
        String[] EmpName = new string[10];
        String[] EmpID = new string[10];
        String[] hireDate = new string[10];

        int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {

            EmpName[currentIndex] = nameBox.Text;
            EmpID[currentIndex] = EmpIdBox.Text;
            hireDate[currentIndex] = datePicker.Text;

            currentIndex++;

            EmpIdBox.Clear();
            nameBox.Clear();
            datePicker.Value = DateTime.Now;

            RefreshDataGridView();

        }

        private void RefreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            int currentYear = DateTime.Now.Year;

            dataGridView1.Rows.Clear();

            for (int i = 0; i < currentIndex; i++)
            {
                int yearsOfExperience = currentYear - DateTime.Parse(hireDate[i]).Year;

                if (yearsOfExperience >= 10)
                {
                    dataGridView1.Rows.Add(EmpName[i], EmpID[i], yearsOfExperience);
                }
            }


        }
    }
}