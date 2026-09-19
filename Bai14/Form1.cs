namespace Bai14
{
    public partial class frm_FormCapNhat : Form
    {
        public frm_FormCapNhat()
        {
            InitializeComponent();
        }

        private void lblTop_CapNhatHeThong_Click(object sender, EventArgs e)
        {

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (txt_Ten.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //đưa con nh|y v{o ô txtTen 
                txt_Ten.Focus();
            }
            else
            {
                //truyền dữ liệu v{o list box 
                string strDuLieu = txt_Ten.Text;
                lst_LopA.Items.Add(strDuLieu);
                //xóa nội dung trong ô txtTen v{ đưa con nh|y v{o ô n{y 
                txt_Ten.Clear();
                txt_Ten.Focus();
            }
        }
        void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
                if (lst1.GetSelected(i))
                {
                    string stDuLieu = lst1.Items[i].ToString();
                    lst2.Items.Add(stDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                    i++;
        }
        void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string stDuLieu = lst1.Items[0].ToString();
                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }
        private void btn_transRight_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lst_LopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko ? ", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lst_LopA, lst_LopB);
            }
            else
                MessageBox.Show("Danh sach hiện đang rỗng!", "Chú ý");
        }

        private void btn_transLeft_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lst_LopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko ? ", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenDuLieu(lst_LopB, lst_LopA);
            }
            else
                MessageBox.Show("Danh sach hiện đang rỗng!", "Chú ý");
        }

        private void btn_transAllRight_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lst_LopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu đang chọn ko ? ", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lst_LopA, lst_LopB);
            }
            else
                MessageBox.Show("Danh sach hiện đang rỗng!", "Chú ý");
        }

        private void btn_transAllLeft_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lst_LopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu đang chọn ko ? ", "Thông Báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                    chuyenToanBo(lst_LopB, lst_LopA);
            }
            else
                MessageBox.Show("Danh sach hiện đang rỗng!", "Chú ý");
        }
        void xoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
                if (lst.GetSelected(i))
                    lst.Items.RemoveAt(i);
                else
                    i++;
        }

        private void btn_XoaA_Click(object sender, EventArgs e)
        {
            DialogResult hoiXoa;
            if (lst_LopA.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                    xoaDuLieu(lst_LopA);
            }
            else
                MessageBox.Show("Hiện danh sach đang rỗng!", "Chú ý");
        }

        private void btn_XoaB_Click(object sender, EventArgs e)
        {
            DialogResult hoiXoa;
            if (lst_LopB.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                    xoaDuLieu(lst_LopB);
            }
            else
                MessageBox.Show("Hiện danh sach đang rỗng!", "Chú ý");
        }

        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?", 
                "Xác nhận thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ketQua == DialogResult.Yes)
            {
                this.Close(); 
            }
        }
    }
}
