namespace Bai15_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Lấy nội dung từ các Textbox ở Tab 1
            string message = txtMessage.Text;
            string caption = txtCaption.Text;

            // Kiểm tra Tab 2 để chọn kiểu Nút (Buttons)
            MessageBoxButtons buttons = MessageBoxButtons.OK; // Khởi tạo mặc định
            if (radBtnOKCancel.Checked) buttons = MessageBoxButtons.OKCancel;
            else if (radBtnRetryCancel.Checked) buttons = MessageBoxButtons.RetryCancel;
            else if (radBtnYesNo.Checked) buttons = MessageBoxButtons.YesNo;
            else if (radBtnYesNoCancel.Checked) buttons = MessageBoxButtons.YesNoCancel;

            // Kiểm tra Tab 3 để chọn Biểu tượng (Icon)
            MessageBoxIcon icon = MessageBoxIcon.None; // Khởi tạo mặc định
            if (radIconError.Checked) icon = MessageBoxIcon.Error;
            else if (radIconInfo.Checked) icon = MessageBoxIcon.Information;
            else if (radIconQuestion.Checked) icon = MessageBoxIcon.Question;
            else if (radIconWarning.Checked) icon = MessageBoxIcon.Warning;

            // Hiển thị MessageBox với các tham số đã lấy được
            MessageBox.Show(message, caption, buttons, icon);
        }

        private void radAlignLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radAlignLeft.Checked)
                tabControl1.Alignment = TabAlignment.Left;
        }

        private void radAlignRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radAlignRight.Checked)
                tabControl1.Alignment = TabAlignment.Right;
        }

        private void radAlignTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radAlignTop.Checked)
                tabControl1.Alignment = TabAlignment.Top;
        }

        private void radAlignBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (radAlignBottom.Checked)
                tabControl1.Alignment = TabAlignment.Bottom;
        }
    }
}
