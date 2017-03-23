namespace Hackathon_Rajasthan
{
    partial class Intermediate_Error
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.intererror_bh = new System.Windows.Forms.Label();
            this.intererror_hin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // intererror_bh
            // 
            this.intererror_bh.AutoSize = true;
            this.intererror_bh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intererror_bh.Location = new System.Drawing.Point(42, 74);
            this.intererror_bh.Name = "intererror_bh";
            this.intererror_bh.Size = new System.Drawing.Size(212, 20);
            this.intererror_bh.TabIndex = 5;
            this.intererror_bh.Text = "Verify Your Bhamasha ID";
            // 
            // intererror_hin
            // 
            this.intererror_hin.AutoSize = true;
            this.intererror_hin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intererror_hin.Location = new System.Drawing.Point(33, 94);
            this.intererror_hin.Name = "intererror_hin";
            this.intererror_hin.Size = new System.Drawing.Size(221, 25);
            this.intererror_hin.TabIndex = 6;
            this.intererror_hin.Text = "भामाशाह आईडी की जांच करें";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pictureBox2.Image = global::Hackathon_Rajasthan.Properties.Resources.error_border1;
            this.pictureBox2.Location = new System.Drawing.Point(113, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pictureBox1.Image = global::Hackathon_Rajasthan.Properties.Resources.White_borders1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Intermediate_Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(287, 130);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.intererror_hin);
            this.Controls.Add(this.intererror_bh);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Intermediate_Error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Intermediate_Error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intererror_bh;
        private System.Windows.Forms.Label intererror_hin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}