namespace QuanLyBinhBauTinNhiem
{
    partial class FormToLapDanhSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.btXemThongTinCaNhan = new System.Windows.Forms.Button();
            this.btXemThongBao = new System.Windows.Forms.Button();
            this.btDSNguoiDiBau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "TỔ LẬP DANH SÁCH";
            // 
            // btXemThongTinCaNhan
            // 
            this.btXemThongTinCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemThongTinCaNhan.Location = new System.Drawing.Point(97, 301);
            this.btXemThongTinCaNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btXemThongTinCaNhan.Name = "btXemThongTinCaNhan";
            this.btXemThongTinCaNhan.Size = new System.Drawing.Size(173, 71);
            this.btXemThongTinCaNhan.TabIndex = 9;
            this.btXemThongTinCaNhan.Text = "XEM THÔNG TIN CÁ NHÂN";
            this.btXemThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btXemThongTinCaNhan.Click += new System.EventHandler(this.btXemThongTinCaNhan_Click);
            // 
            // btXemThongBao
            // 
            this.btXemThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemThongBao.Location = new System.Drawing.Point(97, 192);
            this.btXemThongBao.Margin = new System.Windows.Forms.Padding(2);
            this.btXemThongBao.Name = "btXemThongBao";
            this.btXemThongBao.Size = new System.Drawing.Size(173, 71);
            this.btXemThongBao.TabIndex = 8;
            this.btXemThongBao.Text = "XEM THÔNG BÁO";
            this.btXemThongBao.UseVisualStyleBackColor = true;
            this.btXemThongBao.Click += new System.EventHandler(this.btXemThongBao_Click);
            // 
            // btDSNguoiDiBau
            // 
            this.btDSNguoiDiBau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDSNguoiDiBau.Location = new System.Drawing.Point(97, 92);
            this.btDSNguoiDiBau.Margin = new System.Windows.Forms.Padding(2);
            this.btDSNguoiDiBau.Name = "btDSNguoiDiBau";
            this.btDSNguoiDiBau.Size = new System.Drawing.Size(173, 71);
            this.btDSNguoiDiBau.TabIndex = 7;
            this.btDSNguoiDiBau.Text = "DS NGƯỜI ĐI BẦU";
            this.btDSNguoiDiBau.UseVisualStyleBackColor = true;
            this.btDSNguoiDiBau.Click += new System.EventHandler(this.btDSNguoiDiBau_Click);
            // 
            // FormToLapDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXemThongTinCaNhan);
            this.Controls.Add(this.btXemThongBao);
            this.Controls.Add(this.btDSNguoiDiBau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormToLapDanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormToLapDanhSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXemThongTinCaNhan;
        private System.Windows.Forms.Button btXemThongBao;
        private System.Windows.Forms.Button btDSNguoiDiBau;
    }
}