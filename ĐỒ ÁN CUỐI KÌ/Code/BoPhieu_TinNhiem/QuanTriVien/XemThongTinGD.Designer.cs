namespace BoPhieu_TinNhiem.QuanTriVien
{
    partial class XemThongTinGD
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
            this.rB_User = new System.Windows.Forms.RadioButton();
            this.rB_Role = new System.Windows.Forms.RadioButton();
            this.rB_Table = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_XemTT = new System.Windows.Forms.DataGridView();
            this.button_XemTT = new System.Windows.Forms.Button();
            this.button_QuayVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemTT)).BeginInit();
            this.SuspendLayout();
            // 
            // rB_User
            // 
            this.rB_User.AutoSize = true;
            this.rB_User.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_User.Location = new System.Drawing.Point(73, 61);
            this.rB_User.Name = "rB_User";
            this.rB_User.Size = new System.Drawing.Size(59, 23);
            this.rB_User.TabIndex = 1;
            this.rB_User.TabStop = true;
            this.rB_User.Text = "User";
            this.rB_User.UseVisualStyleBackColor = true;
            // 
            // rB_Role
            // 
            this.rB_Role.AutoSize = true;
            this.rB_Role.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_Role.Location = new System.Drawing.Point(272, 61);
            this.rB_Role.Name = "rB_Role";
            this.rB_Role.Size = new System.Drawing.Size(59, 23);
            this.rB_Role.TabIndex = 2;
            this.rB_Role.TabStop = true;
            this.rB_Role.Text = "Role";
            this.rB_Role.UseVisualStyleBackColor = true;
            // 
            // rB_Table
            // 
            this.rB_Table.AutoSize = true;
            this.rB_Table.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_Table.Location = new System.Drawing.Point(453, 61);
            this.rB_Table.Name = "rB_Table";
            this.rB_Table.Size = new System.Drawing.Size(64, 23);
            this.rB_Table.TabIndex = 3;
            this.rB_Table.TabStop = true;
            this.rB_Table.Text = "Table";
            this.rB_Table.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xem tên của các User, Role, Table có trong Database:";
            // 
            // dgv_XemTT
            // 
            this.dgv_XemTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XemTT.Location = new System.Drawing.Point(21, 148);
            this.dgv_XemTT.Name = "dgv_XemTT";
            this.dgv_XemTT.Size = new System.Drawing.Size(543, 197);
            this.dgv_XemTT.TabIndex = 5;
            // 
            // button_XemTT
            // 
            this.button_XemTT.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XemTT.Location = new System.Drawing.Point(242, 100);
            this.button_XemTT.Name = "button_XemTT";
            this.button_XemTT.Size = new System.Drawing.Size(115, 32);
            this.button_XemTT.TabIndex = 6;
            this.button_XemTT.Text = "Xem";
            this.button_XemTT.UseVisualStyleBackColor = true;
            this.button_XemTT.Click += new System.EventHandler(this.button_XemTT_Click);
            // 
            // button_QuayVe
            // 
            this.button_QuayVe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuayVe.Location = new System.Drawing.Point(411, 100);
            this.button_QuayVe.Name = "button_QuayVe";
            this.button_QuayVe.Size = new System.Drawing.Size(115, 32);
            this.button_QuayVe.TabIndex = 7;
            this.button_QuayVe.Text = "Quay về";
            this.button_QuayVe.UseVisualStyleBackColor = true;
            this.button_QuayVe.Click += new System.EventHandler(this.button_QuayVe_Click);
            // 
            // XemThongTinGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 357);
            this.Controls.Add(this.button_QuayVe);
            this.Controls.Add(this.button_XemTT);
            this.Controls.Add(this.dgv_XemTT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rB_Table);
            this.Controls.Add(this.rB_Role);
            this.Controls.Add(this.rB_User);
            this.Name = "XemThongTinGD";
            this.Text = "XemThongTinGD";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rB_User;
        private System.Windows.Forms.RadioButton rB_Role;
        private System.Windows.Forms.RadioButton rB_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_XemTT;
        private System.Windows.Forms.Button button_XemTT;
        private System.Windows.Forms.Button button_QuayVe;
    }
}