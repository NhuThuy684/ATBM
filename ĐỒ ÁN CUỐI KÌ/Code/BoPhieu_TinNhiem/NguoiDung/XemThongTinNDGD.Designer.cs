namespace BoPhieu_TinNhiem.NguoiDung
{
    partial class XemThongTinNDGD
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
            this.dgv_XemTTND = new System.Windows.Forms.DataGridView();
            this.button_XemND = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_QuayVe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemTTND)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_XemTTND
            // 
            this.dgv_XemTTND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XemTTND.Location = new System.Drawing.Point(34, 125);
            this.dgv_XemTTND.Name = "dgv_XemTTND";
            this.dgv_XemTTND.Size = new System.Drawing.Size(681, 250);
            this.dgv_XemTTND.TabIndex = 0;
            // 
            // button_XemND
            // 
            this.button_XemND.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XemND.Location = new System.Drawing.Point(379, 67);
            this.button_XemND.Name = "button_XemND";
            this.button_XemND.Size = new System.Drawing.Size(157, 45);
            this.button_XemND.TabIndex = 1;
            this.button_XemND.Text = "Xem thông tin";
            this.button_XemND.UseVisualStyleBackColor = true;
            this.button_XemND.Click += new System.EventHandler(this.button_XemND_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(34, 84);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(140, 20);
            this.txt_UserName.TabIndex = 2;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(206, 84);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(134, 20);
            this.txt_Pass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "XEM THÔNG TIN  THÀNH VIÊN";
            // 
            // button_QuayVe
            // 
            this.button_QuayVe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuayVe.Location = new System.Drawing.Point(567, 67);
            this.button_QuayVe.Name = "button_QuayVe";
            this.button_QuayVe.Size = new System.Drawing.Size(133, 45);
            this.button_QuayVe.TabIndex = 7;
            this.button_QuayVe.Text = "Quay về";
            this.button_QuayVe.UseVisualStyleBackColor = true;
            this.button_QuayVe.Click += new System.EventHandler(this.button_QuayVe_Click);
            // 
            // XemThongTinNDGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 387);
            this.Controls.Add(this.button_QuayVe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.button_XemND);
            this.Controls.Add(this.dgv_XemTTND);
            this.Name = "XemThongTinNDGD";
            this.Text = "XemThongTinGD";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XemTTND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_XemTTND;
        private System.Windows.Forms.Button button_XemND;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_QuayVe;
    }
}