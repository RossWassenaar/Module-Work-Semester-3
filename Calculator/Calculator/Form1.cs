namespace Calculator
{
    public partial class FormCalculator : Form
    {
        int num1;
        int num2;
        int sum;
        int difference;
        int product;
        float quotient;
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToInt32(textBox_UserInput1.Text);
                num2 = Convert.ToInt32(textBox_UserInput2.Text);
                sum = num1 + num2;
                label_Answer.Text = "The Answer is:\n " + sum;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid whole number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Subtract_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToInt32(textBox_UserInput1.Text);
                num2 = Convert.ToInt32(textBox_UserInput2.Text);
                difference = num1 - num2;
                label_Answer.Text = "The Answer is:\n " + difference;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid whole number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToInt32(textBox_UserInput1.Text);
                num2 = Convert.ToInt32(textBox_UserInput2.Text);
                product = num1 * num2;
                label_Answer.Text = "The Answer is:\n " + product;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid whole number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToInt32(textBox_UserInput1.Text);
                num2 = Convert.ToInt32(textBox_UserInput2.Text);
                float floatNum1 = (float)Convert.ToDecimal(num1);
                float floatNum2 = (float)Convert.ToDecimal(num2);
                quotient = floatNum1 / floatNum2;
                label_Answer.Text = "The Answer is:\n " + quotient;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid whole number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("You cannot divide by 0", "Divide By Zero Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
