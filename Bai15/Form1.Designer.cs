namespace Bai15
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
            dudColor = new DomainUpDown();
            label1 = new Label();
            label2 = new Label();
            nudSize = new NumericUpDown();
            lblSampleText = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            SuspendLayout();
            // 
            // dudColor
            // 
            dudColor.AllowDrop = true;
            dudColor.Items.Add("Red");
            dudColor.Items.Add("Blue");
            dudColor.Items.Add("Green");
            dudColor.Items.Add("Yellow");
            dudColor.Location = new Point(401, 88);
            dudColor.Name = "dudColor";
            dudColor.Size = new Size(237, 31);
            dudColor.TabIndex = 0;
            dudColor.UpDownAlign = LeftRightAlignment.Left;
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 94);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 161);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 3;
            label2.Text = "Size:";
            // 
            // nudSize
            // 
            nudSize.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nudSize.Location = new Point(401, 155);
            nudSize.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(237, 31);
            nudSize.TabIndex = 4;
            nudSize.ValueChanged += nudSize_ValueChanged;
            // 
            // lblSampleText
            // 
            lblSampleText.AutoSize = true;
            lblSampleText.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSampleText.Location = new Point(352, 271);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(252, 54);
            lblSampleText.TabIndex = 5;
            lblSampleText.Text = "Sample Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 567);
            Controls.Add(lblSampleText);
            Controls.Add(nudSize);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dudColor);
            Name = "Form1";
            Text = "Step By Step";
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown dudColor;
        private Label label1;
        private Label label2;
        private NumericUpDown nudSize;
        private Label lblSampleText;
    }
}
