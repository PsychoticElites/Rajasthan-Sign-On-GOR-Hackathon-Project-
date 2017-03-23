namespace Hackathon_Rajasthan
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.group = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_id = new System.Windows.Forms.Label();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.reg_pass = new System.Windows.Forms.Label();
            this.reg_confpas = new System.Windows.Forms.TextBox();
            this.reg_pas = new System.Windows.Forms.Label();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reg_submit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.Transparent;
            this.group.Controls.Add(this.label5);
            this.group.Controls.Add(this.label3);
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.reg_id);
            this.group.Controls.Add(this.regEmail);
            this.group.Controls.Add(this.reg_pass);
            this.group.Controls.Add(this.reg_confpas);
            this.group.Controls.Add(this.reg_pas);
            this.group.Controls.Add(this.reg_password);
            this.group.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.group.Location = new System.Drawing.Point(330, 193);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(442, 241);
            this.group.TabIndex = 17;
            this.group.TabStop = false;
            this.group.Text = "Details (विवरण)";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = " (पासवर्ड)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "(पासवर्ड)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "(ई-मेल ID)";
            // 
            // reg_id
            // 
            this.reg_id.AutoSize = true;
            this.reg_id.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_id.Location = new System.Drawing.Point(31, 44);
            this.reg_id.Name = "reg_id";
            this.reg_id.Size = new System.Drawing.Size(96, 22);
            this.reg_id.TabIndex = 23;
            this.reg_id.Text = "E-mail ID";
            // 
            // regEmail
            // 
            this.regEmail.Location = new System.Drawing.Point(160, 44);
            this.regEmail.MaxLength = 50;
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(268, 30);
            this.regEmail.TabIndex = 24;
            this.regEmail.TextChanged += new System.EventHandler(this.regEmail_TextChanged);
            // 
            // reg_pass
            // 
            this.reg_pass.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_pass.Location = new System.Drawing.Point(25, 118);
            this.reg_pass.Name = "reg_pass";
            this.reg_pass.Size = new System.Drawing.Size(113, 25);
            this.reg_pass.TabIndex = 19;
            this.reg_pass.Text = "Password";
            // 
            // reg_confpas
            // 
            this.reg_confpas.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.reg_confpas.Location = new System.Drawing.Point(172, 180);
            this.reg_confpas.MaxLength = 25;
            this.reg_confpas.Name = "reg_confpas";
            this.reg_confpas.Size = new System.Drawing.Size(256, 30);
            this.reg_confpas.TabIndex = 22;
            this.reg_confpas.UseSystemPasswordChar = true;
            this.reg_confpas.TextChanged += new System.EventHandler(this.reg_confpas_TextChanged);
            // 
            // reg_pas
            // 
            this.reg_pas.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_pas.Location = new System.Drawing.Point(3, 180);
            this.reg_pas.Name = "reg_pas";
            this.reg_pas.Size = new System.Drawing.Size(167, 25);
            this.reg_pas.TabIndex = 21;
            this.reg_pas.Text = "Retype Password";
            // 
            // reg_password
            // 
            this.reg_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.reg_password.Location = new System.Drawing.Point(160, 118);
            this.reg_password.MaxLength = 25;
            this.reg_password.Name = "reg_password";
            this.reg_password.Size = new System.Drawing.Size(268, 30);
            this.reg_password.TabIndex = 20;
            this.reg_password.UseSystemPasswordChar = true;
            this.reg_password.TextChanged += new System.EventHandler(this.reg_password_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "(पासवर्ड केवल 25 अक्षर का हो सकता है)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "* Password can be of only 25 Characters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reg_submit
            // 
            this.reg_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_submit.Location = new System.Drawing.Point(469, 436);
            this.reg_submit.Name = "reg_submit";
            this.reg_submit.Size = new System.Drawing.Size(194, 56);
            this.reg_submit.TabIndex = 18;
            this.reg_submit.Text = "Register (पंजीकरण)";
            this.reg_submit.UseVisualStyleBackColor = true;
            this.reg_submit.Click += new System.EventHandler(this.reg_submit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(702, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Silver;
            this.pictureBox6.Image = global::Hackathon_Rajasthan.Properties.Resources.White_borders_Long;
            this.pictureBox6.Location = new System.Drawing.Point(-296, 496);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1158, 73);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Hackathon_Rajasthan.Properties.Resources.Rajasthan_Tourism_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(696, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
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
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Silver;
            this.pictureBox5.Image = global::Hackathon_Rajasthan.Properties.Resources.White_borders_Long;
            this.pictureBox5.Location = new System.Drawing.Point(-84, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1158, 87);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(287, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 46);
            this.label6.TabIndex = 29;
            this.label6.Text = "Rajasthan Sign In";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(396, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(348, 40);
            this.label7.TabIndex = 30;
            this.label7.Text = "Register Your Account";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(462, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 40);
            this.label8.TabIndex = 31;
            this.label8.Text = "अपना खाता बनाएं";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 41);
            this.button1.TabIndex = 53;
            this.button1.Text = "Back to Main Menu (मुख्य मेनू में वापस जाएं)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AcceptButton = this.reg_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Hackathon_Rajasthan.Properties.Resources.jaisalmer_fort_wallpaper_1920x108011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.reg_submit);
            this.Controls.Add(this.group);
            this.Controls.Add(this.label8);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button reg_submit;
        private System.Windows.Forms.TextBox reg_confpas;
        private System.Windows.Forms.Label reg_pas;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.Label reg_pass;
        private System.Windows.Forms.Label reg_id;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}