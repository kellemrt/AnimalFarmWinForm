namespace AnimalFarm
{
    partial class UserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.materialPictureBox1 = new FontAwesome.Sharp.Material.MaterialPictureBox();
            this.ıconBtnLogin = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUsername.Location = new System.Drawing.Point(482, 58);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(165, 30);
            this.tbxUsername.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(482, 101);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(165, 30);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(322, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(158, 26);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Kullanıcı Adı:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(404, 101);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 26);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Şifre:";
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ıconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.ıconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 295;
            this.ıconPictureBox1.Location = new System.Drawing.Point(12, -7);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(295, 298);
            this.ıconPictureBox1.TabIndex = 9;
            this.ıconPictureBox1.TabStop = false;
            // 
            // materialPictureBox1
            // 
            this.materialPictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBox1.IconChar = FontAwesome.Sharp.MaterialIcons.WindowClose;
            this.materialPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.materialPictureBox1.IconSize = 40;
            this.materialPictureBox1.Location = new System.Drawing.Point(626, 8);
            this.materialPictureBox1.Name = "materialPictureBox1";
            this.materialPictureBox1.Size = new System.Drawing.Size(46, 40);
            this.materialPictureBox1.TabIndex = 10;
            this.materialPictureBox1.TabStop = false;
            this.materialPictureBox1.Click += new System.EventHandler(this.materialPictureBox1_Click);
            // 
            // ıconBtnLogin
            // 
            this.ıconBtnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ıconBtnLogin.FlatAppearance.BorderSize = 0;
            this.ıconBtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconBtnLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconBtnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.ıconBtnLogin.IconColor = System.Drawing.Color.Black;
            this.ıconBtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconBtnLogin.IconSize = 45;
            this.ıconBtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconBtnLogin.Location = new System.Drawing.Point(424, 149);
            this.ıconBtnLogin.Name = "ıconBtnLogin";
            this.ıconBtnLogin.Size = new System.Drawing.Size(223, 46);
            this.ıconBtnLogin.TabIndex = 11;
            this.ıconBtnLogin.Text = "GİRİŞ";
            this.ıconBtnLogin.UseVisualStyleBackColor = false;
            this.ıconBtnLogin.Click += new System.EventHandler(this.ıconBtnLogin_Click);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 259);
            this.Controls.Add(this.ıconBtnLogin);
            this.Controls.Add(this.materialPictureBox1);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " BESİ ÇİFTLİĞİ OTOMASYONU";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.Material.MaterialPictureBox materialPictureBox1;
        private FontAwesome.Sharp.IconButton ıconBtnLogin;
    }
}

