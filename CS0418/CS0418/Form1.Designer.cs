namespace CS0418
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
            components = new System.ComponentModel.Container();
            start = new Button();
            stop = new Button();
            reset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(33, 56);
            start.Name = "start";
            start.Size = new Size(75, 23);
            start.TabIndex = 0;
            start.Text = "시작";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // stop
            // 
            stop.Location = new Point(137, 56);
            stop.Name = "stop";
            stop.Size = new Size(75, 23);
            stop.TabIndex = 1;
            stop.Text = "정지";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // reset
            // 
            reset.Location = new Point(239, 56);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 2;
            reset.Text = "초기화";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 16F);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 35);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 101);
            Controls.Add(textBox1);
            Controls.Add(reset);
            Controls.Add(stop);
            Controls.Add(start);
            Name = "Form1";
            Text = "스톱워치 애플리케이션";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private Button stop;
        private Button reset;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
    }
}
