namespace Bai14
{
    partial class frm_FormCapNhat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTop_CapNhatHeThong = new Label();
            lblBottom_Footer = new Label();
            lbl_Name = new Label();
            btn_CapNhat = new Button();
            btn_transRight = new Button();
            btn_transAllRight = new Button();
            btn_transLeft = new Button();
            btn_transAllLeft = new Button();
            lst_LopA = new ListBox();
            lst_LopB = new ListBox();
            btn_KetThuc = new Button();
            btn_XoaA = new Button();
            btn_XoaB = new Button();
            errorProvider1 = new ErrorProvider(components);
            txt_Ten = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTop_CapNhatHeThong
            // 
            lblTop_CapNhatHeThong.BackColor = Color.Cyan;
            lblTop_CapNhatHeThong.Dock = DockStyle.Top;
            lblTop_CapNhatHeThong.ForeColor = Color.Black;
            lblTop_CapNhatHeThong.Location = new Point(0, 0);
            lblTop_CapNhatHeThong.Name = "lblTop_CapNhatHeThong";
            lblTop_CapNhatHeThong.Size = new Size(671, 25);
            lblTop_CapNhatHeThong.TabIndex = 0;
            lblTop_CapNhatHeThong.Text = "   Cập Nhật     Hệ Thống";
            lblTop_CapNhatHeThong.Click += lblTop_CapNhatHeThong_Click;
            // 
            // lblBottom_Footer
            // 
            lblBottom_Footer.BackColor = Color.FromArgb(192, 255, 255);
            lblBottom_Footer.Dock = DockStyle.Bottom;
            lblBottom_Footer.Location = new Point(0, 468);
            lblBottom_Footer.Name = "lblBottom_Footer";
            lblBottom_Footer.Size = new Size(671, 25);
            lblBottom_Footer.TabIndex = 1;
            lblBottom_Footer.Text = "Date Time Designed By Author";
            // 
            // lbl_Name
            // 
            lbl_Name.Anchor = AnchorStyles.None;
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_Name.Location = new Point(42, 69);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(68, 23);
            lbl_Name.TabIndex = 1;
            lbl_Name.Text = "Tên SV:";
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Anchor = AnchorStyles.None;
            btn_CapNhat.BackColor = SystemColors.ButtonFace;
            btn_CapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_CapNhat.Location = new Point(520, 55);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(117, 51);
            btn_CapNhat.TabIndex = 4;
            btn_CapNhat.Text = "Cập Nhật";
            btn_CapNhat.UseVisualStyleBackColor = false;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_transRight
            // 
            btn_transRight.BackColor = SystemColors.ButtonFace;
            btn_transRight.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_transRight.Location = new Point(300, 141);
            btn_transRight.Name = "btn_transRight";
            btn_transRight.Size = new Size(83, 50);
            btn_transRight.TabIndex = 6;
            btn_transRight.Text = ">";
            btn_transRight.UseVisualStyleBackColor = false;
            btn_transRight.Click += btn_transRight_Click;
            // 
            // btn_transAllRight
            // 
            btn_transAllRight.BackColor = SystemColors.ButtonFace;
            btn_transAllRight.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_transAllRight.Location = new Point(300, 197);
            btn_transAllRight.Name = "btn_transAllRight";
            btn_transAllRight.Size = new Size(83, 50);
            btn_transAllRight.TabIndex = 7;
            btn_transAllRight.Text = ">>";
            btn_transAllRight.UseVisualStyleBackColor = false;
            btn_transAllRight.Click += btn_transAllRight_Click;
            // 
            // btn_transLeft
            // 
            btn_transLeft.BackColor = SystemColors.ButtonFace;
            btn_transLeft.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_transLeft.Location = new Point(300, 253);
            btn_transLeft.Name = "btn_transLeft";
            btn_transLeft.Size = new Size(83, 50);
            btn_transLeft.TabIndex = 8;
            btn_transLeft.Text = "<";
            btn_transLeft.UseVisualStyleBackColor = false;
            btn_transLeft.Click += btn_transLeft_Click;
            // 
            // btn_transAllLeft
            // 
            btn_transAllLeft.BackColor = SystemColors.ButtonFace;
            btn_transAllLeft.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_transAllLeft.Location = new Point(300, 309);
            btn_transAllLeft.Name = "btn_transAllLeft";
            btn_transAllLeft.Size = new Size(83, 50);
            btn_transAllLeft.TabIndex = 9;
            btn_transAllLeft.Text = "<<";
            btn_transAllLeft.UseVisualStyleBackColor = false;
            btn_transAllLeft.Click += btn_transAllLeft_Click;
            // 
            // lst_LopA
            // 
            lst_LopA.FormattingEnabled = true;
            lst_LopA.Location = new Point(42, 141);
            lst_LopA.Name = "lst_LopA";
            lst_LopA.SelectionMode = SelectionMode.MultiExtended;
            lst_LopA.Size = new Size(203, 224);
            lst_LopA.TabIndex = 5;
            // 
            // lst_LopB
            // 
            lst_LopB.FormattingEnabled = true;
            lst_LopB.Location = new Point(434, 141);
            lst_LopB.Name = "lst_LopB";
            lst_LopB.SelectionMode = SelectionMode.MultiExtended;
            lst_LopB.Size = new Size(203, 224);
            lst_LopB.TabIndex = 10;
            // 
            // btn_KetThuc
            // 
            btn_KetThuc.BackColor = SystemColors.ButtonFace;
            btn_KetThuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_KetThuc.Location = new Point(252, 397);
            btn_KetThuc.Name = "btn_KetThuc";
            btn_KetThuc.Size = new Size(175, 46);
            btn_KetThuc.TabIndex = 13;
            btn_KetThuc.Text = "Kết Thúc";
            btn_KetThuc.UseVisualStyleBackColor = false;
            btn_KetThuc.Click += btn_KetThuc_Click;
            // 
            // btn_XoaA
            // 
            btn_XoaA.BackColor = SystemColors.ButtonFace;
            btn_XoaA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_XoaA.Location = new Point(42, 397);
            btn_XoaA.Name = "btn_XoaA";
            btn_XoaA.Size = new Size(175, 46);
            btn_XoaA.TabIndex = 14;
            btn_XoaA.Text = "Xóa Lớp A";
            btn_XoaA.UseVisualStyleBackColor = false;
            btn_XoaA.Click += btn_XoaA_Click;
            // 
            // btn_XoaB
            // 
            btn_XoaB.BackColor = SystemColors.ButtonFace;
            btn_XoaB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_XoaB.Location = new Point(462, 397);
            btn_XoaB.Name = "btn_XoaB";
            btn_XoaB.Size = new Size(175, 46);
            btn_XoaB.TabIndex = 15;
            btn_XoaB.Text = "Xóa Lớp B";
            btn_XoaB.UseVisualStyleBackColor = false;
            btn_XoaB.Click += btn_XoaB_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txt_Ten
            // 
            txt_Ten.Font = new Font("Segoe UI", 10F);
            txt_Ten.Location = new Point(139, 65);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(340, 30);
            txt_Ten.TabIndex = 3;
            // 
            // frm_FormCapNhat
            // 
            AcceptButton = btn_CapNhat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 493);
            Controls.Add(txt_Ten);
            Controls.Add(btn_XoaB);
            Controls.Add(btn_XoaA);
            Controls.Add(btn_KetThuc);
            Controls.Add(lst_LopB);
            Controls.Add(lst_LopA);
            Controls.Add(btn_transAllLeft);
            Controls.Add(btn_transLeft);
            Controls.Add(btn_transAllRight);
            Controls.Add(btn_transRight);
            Controls.Add(btn_CapNhat);
            Controls.Add(lbl_Name);
            Controls.Add(lblBottom_Footer);
            Controls.Add(lblTop_CapNhatHeThong);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frm_FormCapNhat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCapNhat";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTop_CapNhatHeThong;
        private Label lblBottom_Footer;
        private Label lbl_Name;
        private Button btn_CapNhat;
        private Button btn_transRight;
        private Button btn_transAllRight;
        private Button btn_transLeft;
        private Button btn_transAllLeft;
        private ListBox lst_LopA;
        private ListBox lst_LopB;
        private Button btn_KetThuc;
        private Button btn_XoaA;
        private Button btn_XoaB;
        private ErrorProvider errorProvider1;
        private TextBox txt_Ten;
    }
}
