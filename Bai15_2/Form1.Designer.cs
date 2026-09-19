namespace Bai15_2
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            radLong = new RadioButton();
            radShort = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(92, 67);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 25);
            label1.Name = "label1";
            label1.Size = new Size(247, 25);
            label1.TabIndex = 1;
            label1.Text = "Select the days you will travel:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(92, 387);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(301, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // radLong
            // 
            radLong.AutoSize = true;
            radLong.Location = new Point(92, 439);
            radLong.Name = "radLong";
            radLong.Size = new Size(119, 29);
            radLong.TabIndex = 3;
            radLong.TabStop = true;
            radLong.Text = "Long Date";
            radLong.UseVisualStyleBackColor = true;
            radLong.MouseClick += radLong_MouseClick;
            // 
            // radShort
            // 
            radShort.AutoSize = true;
            radShort.Location = new Point(252, 439);
            radShort.Name = "radShort";
            radShort.Size = new Size(122, 29);
            radShort.TabIndex = 4;
            radShort.TabStop = true;
            radShort.Text = "Short Date";
            radShort.UseVisualStyleBackColor = true;
            radShort.MouseClick += radShort_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 341);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 5;
            label2.Text = "Product Launch Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 25);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 6;
            label3.Text = "Start Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(509, 119);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 7;
            label4.Text = "End Date:";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(509, 67);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(59, 25);
            lblStartDate.TabIndex = 8;
            lblStartDate.Text = "label5";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(509, 166);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(59, 25);
            lblEndDate.TabIndex = 9;
            lblEndDate.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radShort);
            Controls.Add(radLong);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private RadioButton radLong;
        private RadioButton radShort;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblStartDate;
        private Label lblEndDate;
    }
}
