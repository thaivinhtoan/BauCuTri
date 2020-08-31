namespace QuanLyBinhBauTinNhiem
{
    partial class fBanTochuc
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
            this.butDSUngVien = new System.Windows.Forms.Button();
            this.butNguoiDiBau = new System.Windows.Forms.Button();
            this.butTheoDoiKQ = new System.Windows.Forms.Button();
            this.butGiamSat = new System.Windows.Forms.Button();
            this.butXemTB = new System.Windows.Forms.Button();
            this.butTTCaNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN CHỨC NĂNG QUẢN LÝ";
            // 
            // butDSUngVien
            // 
            this.butDSUngVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDSUngVien.Location = new System.Drawing.Point(141, 87);
            this.butDSUngVien.Name = "butDSUngVien";
            this.butDSUngVien.Size = new System.Drawing.Size(498, 77);
            this.butDSUngVien.TabIndex = 1;
            this.butDSUngVien.Text = "Danh sách ứng cử viên";
            this.butDSUngVien.UseVisualStyleBackColor = true;
            // 
            // butNguoiDiBau
            // 
            this.butNguoiDiBau.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNguoiDiBau.Location = new System.Drawing.Point(141, 194);
            this.butNguoiDiBau.Name = "butNguoiDiBau";
            this.butNguoiDiBau.Size = new System.Drawing.Size(498, 81);
            this.butNguoiDiBau.TabIndex = 2;
            this.butNguoiDiBau.Text = "Tổ lập danh sách người đi bầu";
            this.butNguoiDiBau.UseVisualStyleBackColor = true;
            // 
            // butTheoDoiKQ
            // 
            this.butTheoDoiKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTheoDoiKQ.Location = new System.Drawing.Point(141, 298);
            this.butTheoDoiKQ.Name = "butTheoDoiKQ";
            this.butTheoDoiKQ.Size = new System.Drawing.Size(498, 73);
            this.butTheoDoiKQ.TabIndex = 3;
            this.butTheoDoiKQ.Text = "Tổ theo dõi kết quả";
            this.butTheoDoiKQ.UseVisualStyleBackColor = true;
            // 
            // butGiamSat
            // 
            this.butGiamSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGiamSat.Location = new System.Drawing.Point(141, 399);
            this.butGiamSat.Name = "butGiamSat";
            this.butGiamSat.Size = new System.Drawing.Size(498, 73);
            this.butGiamSat.TabIndex = 4;
            this.butGiamSat.Text = "Tổ giám sát";
            this.butGiamSat.UseVisualStyleBackColor = true;
            // 
            // butXemTB
            // 
            this.butXemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXemTB.Location = new System.Drawing.Point(141, 501);
            this.butXemTB.Name = "butXemTB";
            this.butXemTB.Size = new System.Drawing.Size(498, 64);
            this.butXemTB.TabIndex = 5;
            this.butXemTB.Text = "Xem thông báo";
            this.butXemTB.UseVisualStyleBackColor = true;
            // 
            // butTTCaNhan
            // 
            this.butTTCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTTCaNhan.Location = new System.Drawing.Point(141, 588);
            this.butTTCaNhan.Name = "butTTCaNhan";
            this.butTTCaNhan.Size = new System.Drawing.Size(498, 63);
            this.butTTCaNhan.TabIndex = 6;
            this.butTTCaNhan.Text = "Xem thông tin cá nhân";
            this.butTTCaNhan.UseVisualStyleBackColor = true;
            // 
            // fBanTochuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 691);
            this.Controls.Add(this.butTTCaNhan);
            this.Controls.Add(this.butXemTB);
            this.Controls.Add(this.butGiamSat);
            this.Controls.Add(this.butTheoDoiKQ);
            this.Controls.Add(this.butNguoiDiBau);
            this.Controls.Add(this.butDSUngVien);
            this.Controls.Add(this.label1);
            this.Name = "fBanTochuc";
            this.Text = "fBanTochuc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDSUngVien;
        private System.Windows.Forms.Button butNguoiDiBau;
        private System.Windows.Forms.Button butTheoDoiKQ;
        private System.Windows.Forms.Button butGiamSat;
        private System.Windows.Forms.Button butXemTB;
        private System.Windows.Forms.Button butTTCaNhan;
    }
}