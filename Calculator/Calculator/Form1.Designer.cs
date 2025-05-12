namespace Calculator
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            textBox_UserInput1 = new TextBox();
            textBox_UserInput2 = new TextBox();
            label_FirstNumber = new Label();
            label_SecondNumber = new Label();
            button_Add = new Button();
            label_Answer = new Label();
            button_Subtract = new Button();
            button_Multiply = new Button();
            button_Divide = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_UserInput1
            // 
            textBox_UserInput1.Location = new Point(52, 48);
            textBox_UserInput1.Multiline = true;
            textBox_UserInput1.Name = "textBox_UserInput1";
            textBox_UserInput1.Size = new Size(203, 50);
            textBox_UserInput1.TabIndex = 0;
            // 
            // textBox_UserInput2
            // 
            textBox_UserInput2.Location = new Point(52, 129);
            textBox_UserInput2.Multiline = true;
            textBox_UserInput2.Name = "textBox_UserInput2";
            textBox_UserInput2.Size = new Size(203, 52);
            textBox_UserInput2.TabIndex = 1;
            // 
            // label_FirstNumber
            // 
            label_FirstNumber.AutoSize = true;
            label_FirstNumber.Location = new Point(52, 20);
            label_FirstNumber.Name = "label_FirstNumber";
            label_FirstNumber.Size = new Size(115, 25);
            label_FirstNumber.TabIndex = 2;
            label_FirstNumber.Text = "First Number";
            // 
            // label_SecondNumber
            // 
            label_SecondNumber.AutoSize = true;
            label_SecondNumber.Location = new Point(52, 101);
            label_SecondNumber.Name = "label_SecondNumber";
            label_SecondNumber.Size = new Size(141, 25);
            label_SecondNumber.TabIndex = 3;
            label_SecondNumber.Text = "Second Number";
            // 
            // button_Add
            // 
            button_Add.Location = new Point(294, 48);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(34, 34);
            button_Add.TabIndex = 4;
            button_Add.Text = "+";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // label_Answer
            // 
            label_Answer.AutoSize = true;
            label_Answer.Location = new Point(1273, 548);
            label_Answer.Name = "label_Answer";
            label_Answer.Size = new Size(124, 25);
            label_Answer.TabIndex = 5;
            label_Answer.Text = "The Answer is:";
            // 
            // button_Subtract
            // 
            button_Subtract.Location = new Point(350, 48);
            button_Subtract.Name = "button_Subtract";
            button_Subtract.Size = new Size(34, 34);
            button_Subtract.TabIndex = 6;
            button_Subtract.Text = "-";
            button_Subtract.UseVisualStyleBackColor = true;
            button_Subtract.Click += button_Subtract_Click;
            // 
            // button_Multiply
            // 
            button_Multiply.Location = new Point(294, 96);
            button_Multiply.Name = "button_Multiply";
            button_Multiply.Size = new Size(34, 34);
            button_Multiply.TabIndex = 7;
            button_Multiply.Text = "x";
            button_Multiply.UseVisualStyleBackColor = true;
            button_Multiply.Click += button_Multiply_Click;
            // 
            // button_Divide
            // 
            button_Divide.Location = new Point(350, 96);
            button_Divide.Name = "button_Divide";
            button_Divide.Size = new Size(34, 34);
            button_Divide.TabIndex = 8;
            button_Divide.Text = "/";
            button_Divide.UseVisualStyleBackColor = true;
            button_Divide.Click += button_Divide_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.speechbubble;
            pictureBox1.Location = new Point(1182, 467);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 362);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1970, 1119);
            Controls.Add(button_Divide);
            Controls.Add(button_Multiply);
            Controls.Add(button_Subtract);
            Controls.Add(label_Answer);
            Controls.Add(button_Add);
            Controls.Add(label_SecondNumber);
            Controls.Add(label_FirstNumber);
            Controls.Add(textBox_UserInput2);
            Controls.Add(textBox_UserInput1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "FormCalculator";
            Text = "Form Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_UserInput1;
        private TextBox textBox_UserInput2;
        private Label label_FirstNumber;
        private Label label_SecondNumber;
        private Button button_Add;
        private Label label_Answer;
        private Button button_Subtract;
        private Button button_Multiply;
        private Button button_Divide;
        private PictureBox pictureBox1;
    }
}
