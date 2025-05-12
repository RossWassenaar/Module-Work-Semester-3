using System.ComponentModel;

namespace BudgetApp
{
    public partial class Form1 : Form
    {
        BindingList<string> expenses = new BindingList<string>();
        List<Budget> expenseData = new List<Budget>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_AddExpense_Click(object sender, EventArgs e)
        {
            Budget expense = new Budget(textBox_ExpenseName.Text, float.Parse(textBox_Amount.Text), comboBox_Category.SelectedItem.ToString());
            MessageBox.Show($"Expense Added: \nName: {expense.ExpenseName}, \nAmount: {expense.Amount}, \nCategory: {expense.Category}");
            expenseData.Add(expense);
            expenses.Add(expense.ToString());
            listBox_Expenses.DataSource = expenses;
        }

        private void button_ShowTotal_Click(object sender, EventArgs e)
        {
            float sum = 0;
            foreach (Budget expense in expenseData)
            {
                sum += expense.Amount;
            }
            label_Total.Text = $"Total: R{sum}";
        }
    }
}
