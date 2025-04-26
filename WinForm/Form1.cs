namespace WinForm
{
    public partial class Form1 : Form
    {
        //WinForm 생성자
        public Form1()
        {
            InitializeComponent();
            label1.Text = "간단한 타이머";
            button1.Text = "시작";
            button2.Text = "중지";
            textBox1.Text = "초 표시";
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("왜 눌러", "Why");
        }

        private bool timerCheck = false;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "타이머 시작";
            textBox1.ReadOnly = true;
            timerCheck = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "타이머 종료";
            textBox1.ReadOnly = false;
            timerCheck = false;
            timer1.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int seconds = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timerCheck)
            {
                seconds++;
                textBox1.Text = seconds.ToString();
            }
        }
    }
}
