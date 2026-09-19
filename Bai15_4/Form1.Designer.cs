namespace Bai15_4
{
    partial class Form1
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
            tabControl1 = new TabControl();
            Message = new TabPage();
            txtCaption = new TextBox();
            txtMessage = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Buttons = new TabPage();
            radBtnYesNoCancel = new RadioButton();
            radBtnYesNo = new RadioButton();
            radBtnRetryCancel = new RadioButton();
            radBtnOKCancel = new RadioButton();
            radBtnOK = new RadioButton();
            Icon = new TabPage();
            radIconWarning = new RadioButton();
            radIconQuestion = new RadioButton();
            radIconNone = new RadioButton();
            radIconInfo = new RadioButton();
            radIconError = new RadioButton();
            btnShow = new Button();
            groupBox1 = new GroupBox();
            radAlignBottom = new RadioButton();
            radAlignRight = new RadioButton();
            radAlignTop = new RadioButton();
            radAlignLeft = new RadioButton();
            tabControl1.SuspendLayout();
            Message.SuspendLayout();
            Buttons.SuspendLayout();
            Icon.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Message);
            tabControl1.Controls.Add(Buttons);
            tabControl1.Controls.Add(Icon);
            tabControl1.Location = new Point(294, 25);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(371, 252);
            tabControl1.TabIndex = 0;
            // 
            // Message
            // 
            Message.Controls.Add(txtCaption);
            Message.Controls.Add(txtMessage);
            Message.Controls.Add(label2);
            Message.Controls.Add(label1);
            Message.Location = new Point(4, 34);
            Message.Name = "Message";
            Message.Padding = new Padding(3);
            Message.Size = new Size(363, 214);
            Message.TabIndex = 0;
            Message.Text = "Message";
            Message.UseVisualStyleBackColor = true;
            // 
            // txtCaption
            // 
            txtCaption.Location = new Point(41, 169);
            txtCaption.Name = "txtCaption";
            txtCaption.Size = new Size(277, 31);
            txtCaption.TabIndex = 3;
            txtCaption.Text = "Tab Control Demo";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(41, 40);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(277, 98);
            txtMessage.TabIndex = 2;
            txtMessage.Text = "Sample Message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 141);
            label2.Name = "label2";
            label2.Size = new Size(269, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter a Caption for MessageBox:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 12);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter the message to display:";
            // 
            // Buttons
            // 
            Buttons.Controls.Add(radBtnYesNoCancel);
            Buttons.Controls.Add(radBtnYesNo);
            Buttons.Controls.Add(radBtnRetryCancel);
            Buttons.Controls.Add(radBtnOKCancel);
            Buttons.Controls.Add(radBtnOK);
            Buttons.Location = new Point(4, 34);
            Buttons.Name = "Buttons";
            Buttons.Padding = new Padding(3);
            Buttons.Size = new Size(363, 214);
            Buttons.TabIndex = 1;
            Buttons.Text = "Buttons";
            Buttons.UseVisualStyleBackColor = true;
            // 
            // radBtnYesNoCancel
            // 
            radBtnYesNoCancel.AutoSize = true;
            radBtnYesNoCancel.Location = new Point(64, 157);
            radBtnYesNoCancel.Name = "radBtnYesNoCancel";
            radBtnYesNoCancel.Size = new Size(186, 29);
            radBtnYesNoCancel.TabIndex = 4;
            radBtnYesNoCancel.Text = "Yes, No and Cancel";
            radBtnYesNoCancel.UseVisualStyleBackColor = true;
            // 
            // radBtnYesNo
            // 
            radBtnYesNo.AutoSize = true;
            radBtnYesNo.Location = new Point(64, 122);
            radBtnYesNo.Name = "radBtnYesNo";
            radBtnYesNo.Size = new Size(126, 29);
            radBtnYesNo.TabIndex = 3;
            radBtnYesNo.Text = "Yes and No";
            radBtnYesNo.UseVisualStyleBackColor = true;
            // 
            // radBtnRetryCancel
            // 
            radBtnRetryCancel.AutoSize = true;
            radBtnRetryCancel.Location = new Point(64, 87);
            radBtnRetryCancel.Name = "radBtnRetryCancel";
            radBtnRetryCancel.Size = new Size(168, 29);
            radBtnRetryCancel.TabIndex = 2;
            radBtnRetryCancel.Text = "Retry and Cancel";
            radBtnRetryCancel.UseVisualStyleBackColor = true;
            // 
            // radBtnOKCancel
            // 
            radBtnOKCancel.AutoSize = true;
            radBtnOKCancel.Location = new Point(64, 52);
            radBtnOKCancel.Name = "radBtnOKCancel";
            radBtnOKCancel.Size = new Size(152, 29);
            radBtnOKCancel.TabIndex = 1;
            radBtnOKCancel.Text = "OK and Cancel";
            radBtnOKCancel.UseVisualStyleBackColor = true;
            // 
            // radBtnOK
            // 
            radBtnOK.AutoSize = true;
            radBtnOK.Checked = true;
            radBtnOK.Location = new Point(64, 17);
            radBtnOK.Name = "radBtnOK";
            radBtnOK.Size = new Size(61, 29);
            radBtnOK.TabIndex = 0;
            radBtnOK.TabStop = true;
            radBtnOK.Text = "OK";
            radBtnOK.UseVisualStyleBackColor = true;
            // 
            // Icon
            // 
            Icon.Controls.Add(radIconWarning);
            Icon.Controls.Add(radIconQuestion);
            Icon.Controls.Add(radIconNone);
            Icon.Controls.Add(radIconInfo);
            Icon.Controls.Add(radIconError);
            Icon.Location = new Point(4, 34);
            Icon.Name = "Icon";
            Icon.Padding = new Padding(3);
            Icon.Size = new Size(363, 214);
            Icon.TabIndex = 2;
            Icon.Text = "Icon";
            Icon.UseVisualStyleBackColor = true;
            // 
            // radIconWarning
            // 
            radIconWarning.AutoSize = true;
            radIconWarning.Location = new Point(60, 150);
            radIconWarning.Name = "radIconWarning";
            radIconWarning.Size = new Size(103, 29);
            radIconWarning.TabIndex = 4;
            radIconWarning.Text = "Warning";
            radIconWarning.UseVisualStyleBackColor = true;
            // 
            // radIconQuestion
            // 
            radIconQuestion.AutoSize = true;
            radIconQuestion.Location = new Point(60, 115);
            radIconQuestion.Name = "radIconQuestion";
            radIconQuestion.Size = new Size(109, 29);
            radIconQuestion.TabIndex = 3;
            radIconQuestion.Text = "Question";
            radIconQuestion.UseVisualStyleBackColor = true;
            // 
            // radIconNone
            // 
            radIconNone.AutoSize = true;
            radIconNone.Location = new Point(60, 80);
            radIconNone.Name = "radIconNone";
            radIconNone.Size = new Size(80, 29);
            radIconNone.TabIndex = 2;
            radIconNone.Text = "None";
            radIconNone.UseVisualStyleBackColor = true;
            // 
            // radIconInfo
            // 
            radIconInfo.AutoSize = true;
            radIconInfo.Checked = true;
            radIconInfo.Location = new Point(60, 45);
            radIconInfo.Name = "radIconInfo";
            radIconInfo.Size = new Size(131, 29);
            radIconInfo.TabIndex = 1;
            radIconInfo.TabStop = true;
            radIconInfo.Text = "Information";
            radIconInfo.UseVisualStyleBackColor = true;
            // 
            // radIconError
            // 
            radIconError.AutoSize = true;
            radIconError.Location = new Point(60, 10);
            radIconError.Name = "radIconError";
            radIconError.Size = new Size(75, 29);
            radIconError.TabIndex = 0;
            radIconError.Text = "Error";
            radIconError.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(417, 322);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(112, 34);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show!";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radAlignBottom);
            groupBox1.Controls.Add(radAlignRight);
            groupBox1.Controls.Add(radAlignTop);
            groupBox1.Controls.Add(radAlignLeft);
            groupBox1.Location = new Point(327, 391);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tab Layout";
            // 
            // radAlignBottom
            // 
            radAlignBottom.AutoSize = true;
            radAlignBottom.Location = new Point(156, 91);
            radAlignBottom.Name = "radAlignBottom";
            radAlignBottom.Size = new Size(97, 29);
            radAlignBottom.TabIndex = 3;
            radAlignBottom.Text = "Bottom";
            radAlignBottom.UseVisualStyleBackColor = true;
            radAlignBottom.CheckedChanged += radAlignBottom_CheckedChanged;
            // 
            // radAlignRight
            // 
            radAlignRight.AutoSize = true;
            radAlignRight.Location = new Point(156, 42);
            radAlignRight.Name = "radAlignRight";
            radAlignRight.Size = new Size(79, 29);
            radAlignRight.TabIndex = 2;
            radAlignRight.Text = "Right";
            radAlignRight.UseVisualStyleBackColor = true;
            radAlignRight.CheckedChanged += radAlignRight_CheckedChanged;
            // 
            // radAlignTop
            // 
            radAlignTop.AutoSize = true;
            radAlignTop.Checked = true;
            radAlignTop.Location = new Point(14, 91);
            radAlignTop.Name = "radAlignTop";
            radAlignTop.Size = new Size(66, 29);
            radAlignTop.TabIndex = 1;
            radAlignTop.TabStop = true;
            radAlignTop.Text = "Top";
            radAlignTop.UseVisualStyleBackColor = true;
            radAlignTop.CheckedChanged += radAlignTop_CheckedChanged;
            // 
            // radAlignLeft
            // 
            radAlignLeft.AutoSize = true;
            radAlignLeft.Location = new Point(16, 42);
            radAlignLeft.Name = "radAlignLeft";
            radAlignLeft.Size = new Size(66, 29);
            radAlignLeft.TabIndex = 0;
            radAlignLeft.Text = "Left";
            radAlignLeft.UseVisualStyleBackColor = true;
            radAlignLeft.CheckedChanged += radAlignLeft_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 553);
            Controls.Add(btnShow);
            Controls.Add(groupBox1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Message.ResumeLayout(false);
            Message.PerformLayout();
            Buttons.ResumeLayout(false);
            Buttons.PerformLayout();
            Icon.ResumeLayout(false);
            Icon.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Message;
        private TabPage Buttons;
        private TabPage Icon;
        private Button btnShow;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtCaption;
        private TextBox txtMessage;
        private RadioButton radBtnYesNoCancel;
        private RadioButton radBtnYesNo;
        private RadioButton radBtnRetryCancel;
        private RadioButton radBtnOKCancel;
        private RadioButton radBtnOK;
        private RadioButton radIconWarning;
        private RadioButton radIconQuestion;
        private RadioButton radIconNone;
        private RadioButton radIconInfo;
        private RadioButton radIconError;
        private RadioButton radAlignBottom;
        private RadioButton radAlignRight;
        private RadioButton radAlignTop;
        private RadioButton radAlignLeft;
    }
}
