namespace BoPhieu_TinNhiem
{
    partial class MaHoaGD
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.button_MaHoa = new System.Windows.Forms.Button();
            this.dgv_XemMaHoa = new System.Windows.Forms.DataGridView();
            this.dgv_XemGiaiMa = new System.Windows.Forms.DataGridView();
            this.button_GiaiMa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemMaHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemGiaiMa)).BeginInit();
            this.SuspendLayout();
            // 
            // button_QuayVe
            // 
            this.button_QuayVe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuayVe.Location = new System.Drawing.Point(576, 87);
            this.button_QuayVe.Name = "button_QuayVe";
            this.button_QuayVe.Size = new System.Drawing.Size(133, 45);
            this.button_QuayVe.TabIndex = 15;
            this.button_QuayVe.Text = "Quay về";
            this.button_QuayVe.UseVisualStyleBackColor = true;
            this.button_QuayVe.Click += new System.EventHandler(this.button_QuayVe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "XEM THÔNG TIN MÃ HÓA ĐỊA CHỈ CÔNG TÁC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "UserName:";
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(29, 112);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(140, 20);
            this.txt_Pass.TabIndex = 11;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(29, 63);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(140, 20);
            this.txt_UserName.TabIndex = 10;
            // 
            // button_MaHoa
            // 
            this.button_MaHoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MaHoa.Location = new System.Drawing.Point(207, 87);
            this.button_MaHoa.Name = "button_MaHoa";
            this.button_MaHoa.Size = new System.Drawing.Size(157, 45);
            this.button_MaHoa.TabIndex = 9;
            this.button_MaHoa.Text = "Xem Mã hóa";
            this.button_MaHoa.UseVisualStyleBackColor = true;
            this.button_MaHoa.Click += new System.EventHandler(this.button_MaHoa_Click);
            // 
            // dgv_XemMaHoa
            // 
            this.dgv_XemMaHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_XemMaHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XemMaHoa.Location = new System.Drawing.Point(29, 151);
            this.dgv_XemMaHoa.Name = "dgv_XemMaHoa";
            this.dgv_XemMaHoa.Size = new System.Drawing.Size(351, 222);
            this.dgv_XemMaHoa.TabIndex = 8;
            // 
            // dgv_XemGiaiMa
            // 
            this.dgv_XemGiaiMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XemGiaiMa.Location = new System.Drawing.Point(386, 151);
            this.dgv_XemGiaiMa.Name = "dgv_XemGiaiMa";
            this.dgv_XemGiaiMa.Size = new System.Drawing.Size(349, 222);
            this.dgv_XemGiaiMa.TabIndex = 16;
            // 
            // button_GiaiMa
            // 
            this.button_GiaiMa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GiaiMa.Location = new System.Drawing.Point(407, 87);
            this.button_GiaiMa.Name = "button_GiaiMa";
            this.button_GiaiMa.Size = new System.Drawing.Size(133, 45);
            this.button_GiaiMa.TabIndex = 17;
            this.button_GiaiMa.Text = "Giải mã";
            this.button_GiaiMa.UseVisualStyleBackColor = true;
            this.button_GiaiMa.Click += new System.EventHandler(this.button_GiaiMa_Click);
            // 
            // MaHoaGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 381);
            this.Controls.Add(this.button_GiaiMa);
            this.Controls.Add(this.dgv_XemGiaiMa);
            this.Controls.Add(this.button_QuayVe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.button_MaHoa);
            this.Controls.Add(this.dgv_XemMaHoa);
            this.Name = "MaHoaGD";
            this.Text = "MaHoaGD";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemMaHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemGiaiMa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_QuayVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Button button_MaHoa;
        private System.Windows.Forms.DataGridView dgv_XemMaHoa;
        private System.Windows.Forms.DataGridView dgv_XemGiaiMa;
        private System.Windows.Forms.Button button_GiaiMa;
    }
}