namespace ex6_38
{
    public partial class Form1 : Form
    {
        //������
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //�ν��Ͻ� �޼ҵ�
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            label1.Text += "+";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int elapsedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            textBox1.Text = elapsedTime + "�� ���";
            label1.Text = elapsedTime + "�� ���";
        }
    }
}
