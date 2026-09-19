namespace Bai15_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
            else
            {
                // Khởi động lại từ 0 khi đã chạy đầy
                progressBar1.Value = 0;
            }

            // Cập nhật con số hiển thị lên Label
            lblPercentage.Text = "Percentage Complete: " + progressBar1.Value + "%";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / trackBar1.Value;
        }
    }
}

