namespace Hackathon_Rajasthan
{
    partial class ExisitngUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExisitngUser));
            this.login_username = new System.Windows.Forms.Label();
            this.login_user = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.login_submit = new System.Windows.Forms.Button();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_pass = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1_introeng = new System.Windows.Forms.Label();
            this.label1_introhind = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // login_username
            // 
            this.login_username.AutoSize = true;
            this.login_username.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(17, 47);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(234, 24);
            this.login_username.TabIndex = 2;
            this.login_username.Text = "UserName (उपयोगकर्ता नाम)";
            // 
            // login_user
            // 
            this.login_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_user.Location = new System.Drawing.Point(271, 45);
            this.login_user.MaxLength = 50;
            this.login_user.Name = "login_user";
            this.login_user.Size = new System.Drawing.Size(199, 29);
            this.login_user.TabIndex = 3;
            this.login_user.TextChanged += new System.EventHandler(this.login_user_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.login_submit);
            this.groupBox1.Controls.Add(this.login_password);
            this.groupBox1.Controls.Add(this.login_pass);
            this.groupBox1.Controls.Add(this.login_user);
            this.groupBox1.Controls.Add(this.login_username);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(370, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            // 
            // login_submit
            // 
            this.login_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_submit.Location = new System.Drawing.Point(168, 149);
            this.login_submit.Name = "login_submit";
            this.login_submit.Size = new System.Drawing.Size(176, 45);
            this.login_submit.TabIndex = 12;
            this.login_submit.Text = "Submit (जमा करें)";
            this.login_submit.UseVisualStyleBackColor = true;
            this.login_submit.Click += new System.EventHandler(this.login_submit_Click);
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(271, 97);
            this.login_password.MaxLength = 25;
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(199, 29);
            this.login_password.TabIndex = 9;
            this.login_password.UseSystemPasswordChar = true;
            // 
            // login_pass
            // 
            this.login_pass.AutoSize = true;
            this.login_pass.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pass.Location = new System.Drawing.Point(81, 99);
            this.login_pass.Name = "login_pass";
            this.login_pass.Size = new System.Drawing.Size(167, 24);
            this.login_pass.TabIndex = 8;
            this.login_pass.Text = "Password (पासवर्ड)";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Silver;
            this.pictureBox6.Image = global::Hackathon_Rajasthan.Properties.Resources.White_borders_Long;
            this.pictureBox6.Location = new System.Drawing.Point(-244, 524);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1158, 77);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Silver;
            this.pictureBox5.Image = global::Hackathon_Rajasthan.Properties.Resources.White_borders_Long;
            this.pictureBox5.Location = new System.Drawing.Point(-96, -4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1158, 87);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(783, 532);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Hackathon_Rajasthan.Properties.Resources.Rajasthan_Tourism_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(783, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Hackathon_Rajasthan.Properties.Resources.Govt_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1_introeng
            // 
            this.label1_introeng.AutoSize = true;
            this.label1_introeng.BackColor = System.Drawing.Color.White;
            this.label1_introeng.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_introeng.Location = new System.Drawing.Point(269, 13);
            this.label1_introeng.Name = "label1_introeng";
            this.label1_introeng.Size = new System.Drawing.Size(435, 29);
            this.label1_introeng.TabIndex = 18;
            this.label1_introeng.Text = "WELCOME TO RAJASTHAN SIGN IN";
            // 
            // label1_introhind
            // 
            this.label1_introhind.BackColor = System.Drawing.Color.White;
            this.label1_introhind.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_introhind.Location = new System.Drawing.Point(300, 43);
            this.label1_introhind.Name = "label1_introhind";
            this.label1_introhind.Size = new System.Drawing.Size(381, 35);
            this.label1_introhind.TabIndex = 19;
            this.label1_introhind.Text = "राजस्थान Sign In में आपका स्वागत है";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "* Username is First Name + Last 4 Digits of Aadhar No.";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "* उपयोगकर्ता नाम है , प्रथम नाम और आधार नंबर का अंतिम 4 अंक।";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "* Password Maximum length is 25";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "* पासवर्ड की अधिकतम लंबाई 25 है";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 41);
            this.button1.TabIndex = 53;
            this.button1.Text = "Back to Main Menu (मुख्य मेनू में वापस जाएं)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExisitngUser
            // 
            this.AcceptButton = this.login_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Hackathon_Rajasthan.Properties.Resources.entrance_gate_of_amer_fort_view3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(871, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1_introeng);
            this.Controls.Add(this.label1_introhind);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExisitngUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.ExisitngUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label login_username;
        private System.Windows.Forms.TextBox login_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button login_submit;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label login_pass;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1_introeng;
        private System.Windows.Forms.Label label1_introhind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}