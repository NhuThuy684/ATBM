namespace BoPhieu_TinNhiem
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicPassword = new System.Windows.Forms.PictureBox();
            this.PicUserName = new System.Windows.Forms.PictureBox();
            this.labInCorrect = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.checkHienThiPass = new System.Windows.Forms.CheckBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // PicPassword
            // 
            this.PicPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicPassword.Image = ((System.Drawing.Image)(resources.GetObject("PicPassword.Image")));
            this.PicPassword.Location = new System.Drawing.Point(262, 132);
            this.PicPassword.Name = "PicPassword";
            this.PicPassword.Size = new System.Drawing.Size(32, 30);
            this.PicPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPassword.TabIndex = 33;
            this.PicPassword.TabStop = false;
            // 
            // PicUserName
            // 
            this.PicUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicUserName.Image = ((System.Drawing.Image)(resources.GetObject("PicUserName.Image")));
            this.PicUserName.Location = new System.Drawing.Point(261, 66);
            this.PicUserName.Name = "PicUserName";
            this.PicUserName.Size = new System.Drawing.Size(33, 32);
            this.PicUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUserName.TabIndex = 32;
            this.PicUserName.TabStop = false;
            // 
            // labInCorrect
            // 
            this.labInCorrect.AutoSize = true;
            this.labInCorrect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInCorrect.ForeColor = System.Drawing.Color.Red;
            this.labInCorrect.Location = new System.Drawing.Point(77, 259);
            this.labInCorrect.Name = "labInCorrect";
            this.labInCorrect.Size = new System.Drawing.Size(0, 19);
            this.labInCorrect.TabIndex = 31;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(417, 246);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 44);
            this.Cancel.TabIndex = 30;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Login.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(262, 246);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(101, 44);
            this.Login.TabIndex = 29;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // checkHienThiPass
            // 
            this.checkHienThiPass.AutoSize = true;
            this.checkHienThiPass.Location = new System.Drawing.Point(224, 180);
            this.checkHienThiPass.Name = "checkHienThiPass";
            this.checkHienThiPass.Size = new System.Drawing.Size(102, 17);
            this.checkHienThiPass.TabIndex = 28;
            this.checkHienThiPass.Text = "Show Password";
            this.checkHienThiPass.UseVisualStyleBackColor = true;
            this.checkHienThiPass.CheckedChanged += new System.EventHandler(this.checkHienThiPass_CheckedChanged);
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labPassword.Location = new System.Drawing.Point(236, 101);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(90, 22);
            this.labPassword.TabIndex = 27;
            this.labPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(290, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(181, 26);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(290, 72);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(181, 26);
            this.txtUserName.TabIndex = 25;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labUserName.Location = new System.Drawing.Point(236, 41);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(96, 22);
            this.labUserName.TabIndex = 24;
            this.labUserName.Text = "UserName";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PicPassword);
            this.Controls.Add(this.PicUserName);
            this.Controls.Add(this.labInCorrect);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.checkHienThiPass);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labUserName);
            this.Name = "FormMain";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUserName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicPassword;
        private System.Windows.Forms.PictureBox PicUserName;
        private System.Windows.Forms.Label labInCorrect;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.CheckBox checkHienThiPass;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labUserName;
    }
}