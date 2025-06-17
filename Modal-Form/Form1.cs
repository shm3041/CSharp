namespace Modal_Form
{
    public partial class Form1 : Form
    {
        //실제 프로젝트 진행 시 각 함수의 이름은 영어로 선언할 것.
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //Text = "Winform Menu Example";
            //statusLabel.Text = "상태: 대기중";
            //modalButton.Text = "모달 대화상자";
            //modalessButton.Text = "모달리스 대화상자";
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("새 문서를 만듭니다.", "새로 만들기",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            statusLabel.Text = "상태: 새 문서 생성됨.";
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("프로그램을 종료?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
