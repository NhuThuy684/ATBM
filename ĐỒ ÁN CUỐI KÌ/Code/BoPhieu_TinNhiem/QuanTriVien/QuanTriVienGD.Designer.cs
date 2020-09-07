namespace BoPhieu_TinNhiem.QuanTriVien
{
    partial class QuanTriVienGD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanTriVienGD));
            this.label1 = new System.Windows.Forms.Label();
            this.button_XemTTND = new System.Windows.Forms.Button();
            this.button_HieuChinh = new System.Windows.Forms.Button();
            this.button_QuyenTruyCap = new System.Windows.Forms.Button();
            this.dataGridView_KQQTV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Audit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DoiTuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KQQTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIAO DIỆN DÀNH CHO QUẢN TRỊ VIÊN";
            // 
            // button_XemTTND
            // 
            this.button_XemTTND.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XemTTND.Location = new System.Drawing.Point(72, 132);
            this.button_XemTTND.Name = "button_XemTTND";
            this.button_XemTTND.Size = new System.Drawing.Size(211, 55);
            this.button_XemTTND.TabIndex = 1;
            this.button_XemTTND.Text = "Xem User, Role, Table";
            this.button_XemTTND.UseVisualStyleBackColor = true;
            this.button_XemTTND.Click += new System.EventHandler(this.button_XemTTND_Click);
            // 
            // button_HieuChinh
            // 
            this.button_HieuChinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HieuChinh.Location = new System.Drawing.Point(72, 380);
            this.button_HieuChinh.Name = "button_HieuChinh";
            this.button_HieuChinh.Size = new System.Drawing.Size(211, 59);
            this.button_HieuChinh.TabIndex = 2;
            this.button_HieuChinh.Text = "Thêm User, Role";
            this.button_HieuChinh.UseVisualStyleBackColor = true;
            this.button_HieuChinh.Click += new System.EventHandler(this.button_HieuChinh_Click);
            // 
            // button_QuyenTruyCap
            // 
            this.button_QuyenTruyCap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuyenTruyCap.Location = new System.Drawing.Point(74, 298);
            this.button_QuyenTruyCap.Name = "button_QuyenTruyCap";
            this.button_QuyenTruyCap.Size = new System.Drawing.Size(210, 55);
            this.button_QuyenTruyCap.TabIndex = 3;
            this.button_QuyenTruyCap.Text = "Cấp và thu lại quyền";
            this.button_QuyenTruyCap.UseVisualStyleBackColor = true;
            this.button_QuyenTruyCap.Click += new System.EventHandler(this.button_QuyenTruyCap_Click);
            // 
            // dataGridView_KQQTV
            // 
            this.dataGridView_KQQTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KQQTV.Location = new System.Drawing.Point(331, 191);
            this.dataGridView_KQQTV.Name = "dataGridView_KQQTV";
            this.dataGridView_KQQTV.Size = new System.Drawing.Size(560, 330);
            this.dataGridView_KQQTV.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button_Audit
            // 
            this.button_Audit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Audit.Location = new System.Drawing.Point(72, 466);
            this.button_Audit.Name = "button_Audit";
            this.button_Audit.Size = new System.Drawing.Size(211, 55);
            this.button_Audit.TabIndex = 12;
            this.button_Audit.Text = "Xem lịch sử Audit";
            this.button_Audit.UseVisualStyleBackColor = true;
            this.button_Audit.Click += new System.EventHandler(this.button_Audit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Xem thông tin một đối tượng cụ thể";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập tên đối tượng:";
            // 
            // txt_DoiTuong
            // 
            this.txt_DoiTuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DoiTuong.Location = new System.Drawing.Point(331, 132);
            this.txt_DoiTuong.Name = "txt_DoiTuong";
            this.txt_DoiTuong.Size = new System.Drawing.Size(173, 26);
            this.txt_DoiTuong.TabIndex = 17;
            // 
            // QuanTriVienGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DoiTuong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Audit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView_KQQTV);
            this.Controls.Add(this.button_QuyenTruyCap);
            this.Controls.Add(this.button_HieuChinh);
            this.Controls.Add(this.button_XemTTND);
            this.Controls.Add(this.label1);
            this.Name = "QuanTriVienGD";
            this.Text = "QuanTriVienGD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KQQTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_XemTTND;
        private System.Windows.Forms.Button button_HieuChinh;
        private System.Windows.Forms.Button button_QuyenTruyCap;
        private System.Windows.Forms.DataGridView dataGridView_KQQTV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Audit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DoiTuong;
    }
}