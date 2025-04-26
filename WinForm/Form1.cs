namespace WinForm
{
    public partial class Form1 : Form
    {
        //WinForm ������
        public Form1()
        {
            InitializeComponent();
            label1.Text = "������ Ÿ�̸�";
            button1.Text = "����";
            button2.Text = "����";
            textBox1.Text = "�� ǥ��";
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�� ����", "Why");
        }

        private bool timerCheck = false;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ÿ�̸� ����";
            textBox1.ReadOnly = true;
            timerCheck = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ÿ�̸� ����";
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
