namespace WinFormsApp1
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
            imgLoad = new Button();
            pictureBox1 = new PictureBox();
            grnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imgLoad
            // 
            imgLoad.Location = new Point(50, 274);
            imgLoad.Name = "imgLoad";
            imgLoad.Size = new Size(75, 23);
            imgLoad.TabIndex = 0;
            imgLoad.Text = "Load";
            imgLoad.UseVisualStyleBackColor = true;
            imgLoad.Click += imgLoad_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(307, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 285);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // grnBtn
            // 
            grnBtn.Location = new Point(39, 231);
            grnBtn.Name = "grnBtn";
            grnBtn.Size = new Size(75, 23);
            grnBtn.TabIndex = 2;
            grnBtn.Text = "OnlyGreen";
            grnBtn.UseVisualStyleBackColor = true;
            grnBtn.Click += grnBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 332);
            Controls.Add(grnBtn);
            Controls.Add(pictureBox1);
            Controls.Add(imgLoad);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button imgLoad;
        private PictureBox pictureBox1;
        private Button grnBtn;
    }
}
