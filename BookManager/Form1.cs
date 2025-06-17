namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "������ ����";
            this.StartPosition = FormStartPosition.CenterScreen;


            label5.Text = DataManager.Books.Count.ToString();
            label6.Text = DataManager.Users.Count.ToString();
            label7.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            label8.Text = DataManager.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now;
            }).Count().ToString();

            dataGridView1.DataSource = DataManager.Books;
            dataGridView2.DataSource = DataManager.Users;
        }

        private void button1_Click(object sender, EventArgs e) //�뿩
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Isbn�� �Է����ּ���.");
            }
            else if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("����� ID�� �Է����ּ���.");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    if (book.isBorrowed)
                    {
                        MessageBox.Show("�̹� �뿩 ���� �����Դϴ�.");
                    }
                    else
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == textBox3.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Books;
                        DataManager.Save();

                        MessageBox.Show("\"" + book.Name + "\"��/�� \"" + user.Name + "\"�Բ� �뿩�Ǿ����ϴ�.");
                    }
                }
                catch (Exception excaption)
                {
                    MessageBox.Show("�������� �ʴ� ���� �Ǵ� ������Դϴ�.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //�ݳ�
        {

        }

        private void BookMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.Books;
        }

        private void UserMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = DataManager.Users;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Book book = dataGridView1?.CurrentRow?.DataBoundItem as Book;
                if (book != null)
                {
                    textBox1.Text = book.Isbn;
                    textBox2.Text = book.Name;
                }
            }
            catch(Exception exception)
            {

            }
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                User user = dataGridView2?.CurrentRow?.DataBoundItem as User;
                if (user != null)
                    textBox3.Text = user.Id.ToString();
            }
            catch(Exception exception)
            {

            }
        }
    }
}
