namespace Modal_Form
{
    public partial class Form1 : Form
    {
        //���� ������Ʈ ���� �� �� �Լ��� �̸��� ����� ������ ��.
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //Text = "Winform Menu Example";
            //statusLabel.Text = "����: �����";
            //modalButton.Text = "��� ��ȭ����";
            //modalessButton.Text = "��޸��� ��ȭ����";
        }

        private void ���θ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�� ������ ����ϴ�.", "���� �����",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            statusLabel.Text = "����: �� ���� ������.";
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("���α׷��� ����?", "����",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
