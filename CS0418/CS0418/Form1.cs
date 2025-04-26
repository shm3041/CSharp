namespace CS0418
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private void UpdateTimeLabel()
        {
            // 00:00:00 형식으로 시간 표시
            textBox1.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
        }


        // 시간을 저장할 변수들
        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;

        // 타이머 상태 변수
        private bool isRunning = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRunning == true)
            {
                seconds++;
                if (seconds == 60)
                {
                    minutes += 1;
                    seconds = 0;
                }
                if (minutes == 60)
                {
                    hours += 1;
                    minutes = 0;
                }
                UpdateTimeLabel();
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                timer1.Start();
                isRunning = true;
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                isRunning = false;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                isRunning = false;
            }
            hours = 0; minutes = 0; seconds = 0;
            UpdateTimeLabel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
