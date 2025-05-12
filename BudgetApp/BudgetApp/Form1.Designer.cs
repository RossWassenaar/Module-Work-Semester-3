namespace BudgetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_ExpenseName = new TextBox();
            textBox_Amount = new TextBox();
            label_ExpenseName = new Label();
            label_Amount = new Label();
            label_Category = new Label();
            button_AddExpense = new Button();
            button_ShowTotal = new Button();
            comboBox_Category = new ComboBox();
            listBox_Expenses = new ListBox();
            label_Total = new Label();
            SuspendLayout();
            // 
            // textBox_ExpenseName
            // 
            textBox_ExpenseName.Location = new Point(57, 69);
            textBox_ExpenseName.Name = "textBox_ExpenseName";
            textBox_ExpenseName.Size = new Size(247, 31);
            textBox_ExpenseName.TabIndex = 0;
            // 
            // textBox_Amount
            // 
            textBox_Amount.Location = new Point(57, 168);
            textBox_Amount.Name = "textBox_Amount";
            textBox_Amount.Size = new Size(247, 31);
            textBox_Amount.TabIndex = 1;
            // 
            // label_ExpenseName
            // 
            label_ExpenseName.AutoSize = true;
            label_ExpenseName.Location = new Point(59, 34);
            label_ExpenseName.Name = "label_ExpenseName";
            label_ExpenseName.Size = new Size(128, 25);
            label_ExpenseName.TabIndex = 2;
            label_ExpenseName.Text = "Expense Name";
            // 
            // label_Amount
            // 
            label_Amount.AutoSize = true;
            label_Amount.Location = new Point(59, 131);
            label_Amount.Name = "label_Amount";
            label_Amount.Size = new Size(77, 25);
            label_Amount.TabIndex = 3;
            label_Amount.Text = "Amount";
            // 
            // label_Category
            // 
            label_Category.AutoSize = true;
            label_Category.Location = new Point(59, 231);
            label_Category.Name = "label_Category";
            label_Category.Size = new Size(84, 25);
            label_Category.TabIndex = 5;
            label_Category.Text = "Category";
            // 
            // button_AddExpense
            // 
            button_AddExpense.Location = new Point(57, 342);
            button_AddExpense.Name = "button_AddExpense";
            button_AddExpense.Size = new Size(159, 34);
            button_AddExpense.TabIndex = 6;
            button_AddExpense.Text = "Add Expense";
            button_AddExpense.UseVisualStyleBackColor = true;
            button_AddExpense.Click += button_AddExpense_Click;
            // 
            // button_ShowTotal
            // 
            button_ShowTotal.Location = new Point(241, 342);
            button_ShowTotal.Name = "button_ShowTotal";
            button_ShowTotal.Size = new Size(159, 34);
            button_ShowTotal.TabIndex = 7;
            button_ShowTotal.Text = "Show Total";
            button_ShowTotal.UseVisualStyleBackColor = true;
            button_ShowTotal.Click += button_ShowTotal_Click;
            // 
            // comboBox_Category
            // 
            comboBox_Category.FormattingEnabled = true;
            comboBox_Category.Items.AddRange(new object[] { "Food", "Transport", "Rent", "Entertainment", "Other" });
            comboBox_Category.Location = new Point(57, 271);
            comboBox_Category.Name = "comboBox_Category";
            comboBox_Category.Size = new Size(182, 33);
            comboBox_Category.TabIndex = 8;
            // 
            // listBox_Expenses
            // 
            listBox_Expenses.FormattingEnabled = true;
            listBox_Expenses.Location = new Point(463, 69);
            listBox_Expenses.Name = "listBox_Expenses";
            listBox_Expenses.Size = new Size(296, 254);
            listBox_Expenses.TabIndex = 9;
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Location = new Point(463, 347);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(58, 25);
            label_Total.TabIndex = 10;
            label_Total.Text = "Total: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Total);
            Controls.Add(listBox_Expenses);
            Controls.Add(comboBox_Category);
            Controls.Add(button_ShowTotal);
            Controls.Add(button_AddExpense);
            Controls.Add(label_Category);
            Controls.Add(label_Amount);
            Controls.Add(label_ExpenseName);
            Controls.Add(textBox_Amount);
            Controls.Add(textBox_ExpenseName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_ExpenseName;
        private TextBox textBox_Amount;
        private Label label_ExpenseName;
        private Label label_Amount;
        private Label label_Category;
        private Button button_AddExpense;
        private Button button_ShowTotal;
        private ComboBox comboBox_Category;
        private ListBox listBox_Expenses;
        private Label label_Total;
    }
}
