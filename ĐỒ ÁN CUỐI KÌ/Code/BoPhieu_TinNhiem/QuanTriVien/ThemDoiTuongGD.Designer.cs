namespace BoPhieu_TinNhiem.QuanTriVien
{
    partial class ThemDoiTuongGD
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
            this.button_QuayVe = new System.Windows.Forms.Button();
            this.button_TaoMoi = new System.Windows.Forms.Button();
            this.dgv_TaoTT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rB_Role = new System.Windows.Forms.RadioButton();
            this.rB_User = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label_tenRole = new System.Windows.Forms.Label();
            this.txt_tenRole = new System.Windows.Forms.TextBox();
            this.label_tenUSer = new System.Windows.Forms.Label();
            this.txt_TenUser = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaoTT)).BeginInit();
            this.SuspendLayout();
            // 
            // button_QuayVe
            // 
            this.button_QuayVe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuayVe.Location = new System.Drawing.Point(476, 193);
            this.button_QuayVe.Name = "button_QuayVe";
            this.button_QuayVe.Size = new System.Drawing.Size(115, 32);
            this.button_QuayVe.TabIndex = 14;
            this.button_QuayVe.Text = "Quay về";
            this.button_QuayVe.UseVisualStyleBackColor = true;
            this.button_QuayVe.Click += new System.EventHandler(this.button_QuayVe_Click);
            // 
            // button_TaoMoi
            // 
            this.button_TaoMoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TaoMoi.Location = new System.Drawing.Point(270, 192);
            this.button_TaoMoi.Name = "button_TaoMoi";
            this.button_TaoMoi.Size = new System.Drawing.Size(115, 32);
            this.button_TaoMoi.TabIndex = 13;
            this.button_TaoMoi.Text = "Tạo mới";
            this.button_TaoMoi.UseVisualStyleBackColor = true;
            this.button_TaoMoi.Click += new System.EventHandler(this.button_TaoMoi_Click);
            // 
            // dgv_TaoTT
            // 
            this.dgv_TaoTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaoTT.Location = new System.Drawing.Point(46, 246);
            this.dgv_TaoTT.Name = "dgv_TaoTT";
            this.dgv_TaoTT.Size = new System.Drawing.Size(592, 217);
            this.dgv_TaoTT.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chọn tên của các User, Role:";
            // 
            // rB_Role
            // 
            this.rB_Role.AutoSize = true;
            this.rB_Role.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_Role.Location = new System.Drawing.Point(433, 56);
            this.rB_Role.Name = "rB_Role";
            this.rB_Role.Size = new System.Drawing.Size(59, 23);
            this.rB_Role.TabIndex = 9;
            this.rB_Role.TabStop = true;
            this.rB_Role.Text = "Role";
            this.rB_Role.UseVisualStyleBackColor = true;
            // 
            // rB_User
            // 
            this.rB_User.AutoSize = true;
            this.rB_User.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_User.Location = new System.Drawing.Point(85, 53);
            this.rB_User.Name = "rB_User";
            this.rB_User.Size = new System.Drawing.Size(59, 23);
            this.rB_User.TabIndex = 8;
            this.rB_User.TabStop = true;
            this.rB_User.Text = "User";
            this.rB_User.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nhập Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(71, 162);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(173, 26);
            this.txt_Password.TabIndex = 25;
            // 
            // label_tenRole
            // 
            this.label_tenRole.AutoSize = true;
            this.label_tenRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenRole.Location = new System.Drawing.Point(381, 82);
            this.label_tenRole.Name = "label_tenRole";
            this.label_tenRole.Size = new System.Drawing.Size(111, 19);
            this.label_tenRole.TabIndex = 24;
            this.label_tenRole.Text = "Nhập tên Role:";
            // 
            // txt_tenRole
            // 
            this.txt_tenRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenRole.Location = new System.Drawing.Point(398, 104);
            this.txt_tenRole.Name = "txt_tenRole";
            this.txt_tenRole.Size = new System.Drawing.Size(173, 26);
            this.txt_tenRole.TabIndex = 23;
            // 
            // label_tenUSer
            // 
            this.label_tenUSer.AutoSize = true;
            this.label_tenUSer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenUSer.Location = new System.Drawing.Point(42, 79);
            this.label_tenUSer.Name = "label_tenUSer";
            this.label_tenUSer.Size = new System.Drawing.Size(111, 19);
            this.label_tenUSer.TabIndex = 22;
            this.label_tenUSer.Text = "Nhập tên User:";
            // 
            // txt_TenUser
            // 
            this.txt_TenUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenUser.Location = new System.Drawing.Point(71, 104);
            this.txt_TenUser.Name = "txt_TenUser";
            this.txt_TenUser.Size = new System.Drawing.Size(173, 26);
            this.txt_TenUser.TabIndex = 21;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(492, 82);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 19);
            this.label.TabIndex = 28;
            // 
            // ThemDoiTuongGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label_tenRole);
            this.Controls.Add(this.txt_tenRole);
            this.Controls.Add(this.label_tenUSer);
            this.Controls.Add(this.txt_TenUser);
            this.Controls.Add(this.button_QuayVe);
            this.Controls.Add(this.button_TaoMoi);
            this.Controls.Add(this.dgv_TaoTT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rB_Role);
            this.Controls.Add(this.rB_User);
            this.Name = "ThemDoiTuongGD";
            this.Text = "ThemDoiTuongGD";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaoTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_QuayVe;
        private System.Windows.Forms.Button button_TaoMoi;
        private System.Windows.Forms.DataGridView dgv_TaoTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rB_Role;
        private System.Windows.Forms.RadioButton rB_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label_tenRole;
        private System.Windows.Forms.TextBox txt_tenRole;
        private System.Windows.Forms.Label label_tenUSer;
        private System.Windows.Forms.TextBox txt_TenUser;
        private System.Windows.Forms.Label label;
    }
}