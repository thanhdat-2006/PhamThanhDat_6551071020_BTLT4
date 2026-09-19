namespace Bai15_3
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblPercentage = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            trackBar1 = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 26);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "Progress Indicator:";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(106, 174);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(59, 25);
            lblPercentage.TabIndex = 1;
            lblPercentage.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 245);
            label3.Name = "label3";
            label3.Size = new Size(380, 25);
            label3.TabIndex = 2;
            label3.Text = "Slide the TrackBar to control processing speed:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(113, 69);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(453, 64);
            progressBar1.TabIndex = 3;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(113, 298);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(453, 69);
            trackBar1.TabIndex = 4;
            trackBar1.Value = 5;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar1);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(lblPercentage);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPercentage;
        private Label label3;
        private ProgressBar progressBar1;
        private TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
