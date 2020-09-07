namespace BoPhieu_TinNhiem.QuanTriVien
{
    partial class CapVaThu_QuyenGD
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
            this.bt_PhanQuyen = new System.Windows.Forms.Button();
            this.cb_Bang = new System.Windows.Forms.ComboBox();
            this.txt_Quyen = new System.Windows.Forms.TextBox();
            this.txt_DoiTuong = new System.Windows.Forms.TextBox();
            this.bt_ThuQuyen = new System.Windows.Forms.Button();
            this.bt_QuayVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_PhanQuyen
            // 
            this.bt_PhanQuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_PhanQuyen.Location = new System.Drawing.Point(52, 146);
            this.bt_PhanQuyen.Name = "bt_PhanQuyen";
            this.bt_PhanQuyen.Size = new System.Drawing.Size(128, 44);
            this.bt_PhanQuyen.TabIndex = 0;
            this.bt_PhanQuyen.Text = "Phân quyền";
            this.bt_PhanQuyen.UseVisualStyleBackColor = true;
            this.bt_PhanQuyen.Click += new System.EventHandler(this.bt_PhanQuyen_Click);
            // 
            // cb_Bang
            // 
            this.cb_Bang.FormattingEnabled = true;
            this.cb_Bang.Items.AddRange(new object[] {
            "THANHVIEN",
            "CHINHANH",
            "BTC",
            "TO_LAP",
            "GIAMSAT",
            "THEODOI",
            "PHIEUBAU",
            "UNGCUVIEN",
            "THONGBAO",
            "DONVI"});
            this.cb_Bang.Location = new System.Drawing.Point(238, 71);
            this.cb_Bang.Name = "cb_Bang";
            this.cb_Bang.Size = new System.Drawing.Size(141, 21);
            this.cb_Bang.TabIndex = 1;
            // 
            // txt_Quyen
            // 
            this.txt_Quyen.Location = new System.Drawing.Point(52, 72);
            this.txt_Quyen.Name = "txt_Quyen";
            this.txt_Quyen.Size = new System.Drawing.Size(142, 20);
            this.txt_Quyen.TabIndex = 2;
            // 
            // txt_DoiTuong
            // 
            this.txt_DoiTuong.Location = new System.Drawing.Point(422, 72);
            this.txt_DoiTuong.Name = "txt_DoiTuong";
            this.txt_DoiTuong.Size = new System.Drawing.Size(137, 20);
            this.txt_DoiTuong.TabIndex = 3;
            // 
            // bt_ThuQuyen
            // 
            this.bt_ThuQuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThuQuyen.Location = new System.Drawing.Point(238, 146);
            this.bt_ThuQuyen.Name = "bt_ThuQuyen";
            this.bt_ThuQuyen.Size = new System.Drawing.Size(136, 44);
            this.bt_ThuQuyen.TabIndex = 4;
            this.bt_ThuQuyen.Text = "Thu lại quyền";
            this.bt_ThuQuyen.UseVisualStyleBackColor = true;
            this.bt_ThuQuyen.Click += new System.EventHandler(this.bt_ThuQuyen_Click);
            // 
            // bt_QuayVe
            // 
            this.bt_QuayVe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_QuayVe.Location = new System.Drawing.Point(446, 146);
            this.bt_QuayVe.Name = "bt_QuayVe";
            this.bt_QuayVe.Size = new System.Drawing.Size(113, 44);
            this.bt_QuayVe.TabIndex = 5;
            this.bt_QuayVe.Text = "Quay về";
            this.bt_QuayVe.UseVisualStyleBackColor = true;
            this.bt_QuayVe.Click += new System.EventHandler(this.bt_QuayVe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quyền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bảng:";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(445, 45);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(82, 19);
            this.l.TabIndex = 10;
            this.l.Text = "Đối tượng:";
            // 
            // CapVaThu_QuyenGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 292);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_QuayVe);
            this.Controls.Add(this.bt_ThuQuyen);
            this.Controls.Add(this.txt_DoiTuong);
            this.Controls.Add(this.txt_Quyen);
            this.Controls.Add(this.cb_Bang);
            this.Controls.Add(this.bt_PhanQuyen);
            this.Name = "CapVaThu_QuyenGD";
            this.Text = "CapVaThu_QuyenGD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_PhanQuyen;
        private System.Windows.Forms.ComboBox cb_Bang;
        private System.Windows.Forms.TextBox txt_Quyen;
        private System.Windows.Forms.TextBox txt_DoiTuong;
        private System.Windows.Forms.Button bt_ThuQuyen;
        private System.Windows.Forms.Button bt_QuayVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l;
    }
}