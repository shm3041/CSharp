using System.ComponentModel;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            PerformCalculation('+');
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            PerformCalculation('-');
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            PerformCalculation('*');
        }

        private void Div_Click(object sender, EventArgs e)
        {
            PerformCalculation('/');
        }

        //TryParse()함수를 모르는 자의 폐해
        private void PerformCalculation(char operation)
        {
            if (TextBox_Num1.Text == "" || TextBox_Num2.Text == "")
            {
                MessageBox.Show("유효한 숫자를 입력하세요!", "오류");
                return;
            }

            int iA = 0, iB = 0;
            double dA = 0, dB = 0;
            bool check = false;

            foreach (var item in TextBox_Num1.Text)
            {
                if(item == '.') { check = true; break; }
            }
            foreach (var item in TextBox_Num2.Text)
            {
                if (item == '.') { check = true; break; }
            }
            if (check) 
            { 
                dA = Convert.ToDouble(TextBox_Num1.Text); 
                dB = Convert.ToDouble(TextBox_Num2.Text);
            }
            else
            { 
                iA = Convert.ToInt32(TextBox_Num1.Text);
                iB = Convert.ToInt32(TextBox_Num2.Text);
            }

            if (operation == '/')
            {
                double result;
                if (TextBox_Num2.Text == "0" || TextBox_Num2.Text == "0.0")
                {
                    MessageBox.Show("0으로 나눌 수 없습니다!", "오류");
                    return;
                }
                if(check == true) { result = dA / dB; }
                else { result = (double)iA / iB; }
                //Result.Text = Convert.ToString(result);
                Result.Text = result.ToString("F2");

                return;
            }

            if (check == true)
            {
                double result = 0;
                if (operation == '+') { result = dA + dB; }
                if (operation == '-') { result = dA - dB; }
                if (operation == '*') { result = dA * dB; }

                //Result.Text = Convert.ToString(result);
                Result.Text = result.ToString("F2");
            }
            else
            {
                int result = 0;
                if (operation == '+') { result = iA + iB; }
                if (operation == '-') { result = iA - iB; }
                if (operation == '*') { result = iA * iB; }

                Result.Text = Convert.ToString(result);
            }
        }
    }
}
