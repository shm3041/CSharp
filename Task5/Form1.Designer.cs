namespace Task5
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
            Label_Num1 = new Label();
            Label_Num2 = new Label();
            TextBox_Num1 = new TextBox();
            TextBox_Num2 = new TextBox();
            Add = new Button();
            Sub = new Button();
            Mul = new Button();
            Div = new Button();
            ResultString = new Label();
            Result = new Label();
            SuspendLayout();
            // 
            // Label_Num1
            // 
            Label_Num1.AutoSize = true;
            Label_Num1.Location = new Point(12, 9);
            Label_Num1.Name = "Label_Num1";
            Label_Num1.Size = new Size(82, 15);
            Label_Num1.TabIndex = 0;
            Label_Num1.Text = "첫 번째 숫자: ";
            // 
            // Label_Num2
            // 
            Label_Num2.AutoSize = true;
            Label_Num2.Location = new Point(12, 40);
            Label_Num2.Name = "Label_Num2";
            Label_Num2.Size = new Size(82, 15);
            Label_Num2.TabIndex = 1;
            Label_Num2.Text = "두 번째 숫자: ";
            // 
            // TextBox_Num1
            // 
            TextBox_Num1.Location = new Point(100, 6);
            TextBox_Num1.Name = "TextBox_Num1";
            TextBox_Num1.Size = new Size(205, 23);
            TextBox_Num1.TabIndex = 2;
            // 
            // TextBox_Num2
            // 
            TextBox_Num2.Location = new Point(100, 35);
            TextBox_Num2.Name = "TextBox_Num2";
            TextBox_Num2.Size = new Size(205, 23);
            TextBox_Num2.TabIndex = 3;
            // 
            // Add
            // 
            Add.Location = new Point(12, 72);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 4;
            Add.Text = "더하기 (+)";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Sub
            // 
            Sub.Location = new Point(93, 72);
            Sub.Name = "Sub";
            Sub.Size = new Size(75, 23);
            Sub.TabIndex = 5;
            Sub.Text = "빼기 (-)";
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Sub_Click;
            // 
            // Mul
            // 
            Mul.Location = new Point(174, 72);
            Mul.Name = "Mul";
            Mul.Size = new Size(75, 23);
            Mul.TabIndex = 6;
            Mul.Text = "곱하기 (x)";
            Mul.UseVisualStyleBackColor = true;
            Mul.Click += Mul_Click;
            // 
            // Div
            // 
            Div.Location = new Point(255, 72);
            Div.Name = "Div";
            Div.Size = new Size(75, 23);
            Div.TabIndex = 7;
            Div.Text = "나누기 (/)";
            Div.UseVisualStyleBackColor = true;
            Div.Click += Div_Click;
            // 
            // ResultString
            // 
            ResultString.AutoSize = true;
            ResultString.Location = new Point(12, 112);
            ResultString.Name = "ResultString";
            ResultString.Size = new Size(34, 15);
            ResultString.TabIndex = 8;
            ResultString.Text = "결과:";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(100, 112);
            Result.Name = "Result";
            Result.Size = new Size(11, 15);
            Result.TabIndex = 9;
            Result.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 150);
            Controls.Add(Result);
            Controls.Add(ResultString);
            Controls.Add(Div);
            Controls.Add(Mul);
            Controls.Add(Sub);
            Controls.Add(Add);
            Controls.Add(TextBox_Num2);
            Controls.Add(TextBox_Num1);
            Controls.Add(Label_Num2);
            Controls.Add(Label_Num1);
            Name = "Form1";
            Text = "간단한 계산기";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Num1;
        private Label Label_Num2;
        private TextBox TextBox_Num1;
        private TextBox TextBox_Num2;
        private Button Add;
        private Button Sub;
        private Button Mul;
        private Button Div;
        private Label ResultString;
        private Label Result;
    }
}
