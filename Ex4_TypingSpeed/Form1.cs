namespace Ex4_TypingSpeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            textBox1.Enabled = false;
        }

        private int ms1000 = 0;
        private int ms100 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ms100++;
            if (ms100 >= 10)
            {
                ms100 = 0;
                ms1000++;
            }
            label3.Text = "����ð�:    " + ms1000 + "." + ms100 + "��";

            if (label2.Text == textBox1.Text)
            {
                timer1.Stop();
                int ms = ms100 + (ms1000 * 10);
                double cpm = 0;
                cpm = 33000 / ms;
                label4.Text = "Ÿ���� �ӵ�:" + cpm.ToString() + "CPM";
                MessageBox.Show($"�����մϴ�! Ÿ���� �ӵ��� {cpm} CPM�Դϴ�.", "Ÿ���� �Ϸ�");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            textBox1.Enabled = true;
            button1.Enabled = false;
            textBox1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Enabled = false;
            button1.Enabled = true;
            textBox1.Text = "";
            label3.Text = "����ð�:    0.0��";
            label4.Text = "Ÿ���� �ӵ� :   0 CPM";
            ms1000 = 0; ms100 = 0;
        }
    }
}
