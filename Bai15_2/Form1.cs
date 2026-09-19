namespace Bai15_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStartDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
            lblEndDate.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblStartDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
            lblEndDate.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void radLong_MouseClick(object sender, MouseEventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Long;
        }

        private void radShort_MouseClick(object sender, MouseEventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }
    }
}
