namespace BudgetAppVersion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_Rent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Rent.Checked)
            {
                radioButton_Mortgage.Enabled = false;
            }
        }

        private void radioButton_Mortgage_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mortgage.Checked)
            {
                radioButton_Rent.Enabled = false;
            }
        }
    }
}
