namespace QuanLyBinhBauTinNhiem
{
    partial class FormBanTochuc
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
            this.btXemTB = new System.Windows.Forms.Button();
            this.btTTCaNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN CHỨC NĂNG QUẢN LÝ";
            // 
            // butDSUngVien
            // 
            this.butDSUngVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDSUngVien.Location = new System.Drawing.Point(79, 68);
            this.butDSUngVien.Margin = new System.Windows.Forms.Padding(2);
            this.butDSUngVien.Name = "butDSUngVien";
            this.butDSUngVien.Size = new System.Drawing.Size(409, 63);
            this.butDSUngVien.TabIndex = 1;
            this.butDSUngVien.Text = "Danh sách ứng cử viên";
            this.butDSUngVien.UseVisualStyleBackColor = true;
            this.butDSUngVien.Click += new System.EventHandler(this.butDSUngVien_Click);
            // 
            // butNguoiDiBau
            // 
            this.butNguoiDiBau.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNguoiDiBau.Location = new System.Drawing.Point(79, 157);
            this.butNguoiDiBau.Margin = new System.Windows.Forms.Padding(2);
            this.butNguoiDiBau.Name = "butNguoiDiBau";
            this.butNguoiDiBau.Size = new System.Drawing.Size(409, 66);
            this.butNguoiDiBau.TabIndex = 2;
            this.butNguoiDiBau.Text = "Tổ lập danh sách người đi bầu";
            this.butNguoiDiBau.UseVisualStyleBackColor = true;
            // 
            // butTheoDoiKQ
            // 
            this.butTheoDoiKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTheoDoiKQ.Location = new System.Drawing.Point(79, 242);
            this.butTheoDoiKQ.Margin = new System.Windows.Forms.Padding(2);
            this.butTheoDoiKQ.Name = "butTheoDoiKQ";
            this.butTheoDoiKQ.Size = new System.Drawing.Size(409, 64);
            this.butTheoDoiKQ.TabIndex = 3;
            this.butTheoDoiKQ.Text = "Tổ theo dõi kết quả";
            this.butTheoDoiKQ.UseVisualStyleBackColor = true;
            // 
            // butGiamSat
            // 
            this.butGiamSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGiamSat.Location = new System.Drawing.Point(79, 324);
            this.butGiamSat.Margin = new System.Windows.Forms.Padding(2);
            this.butGiamSat.Name = "butGiamSat";
            this.butGiamSat.Size = new System.Drawing.Size(401, 59);
            this.butGiamSat.TabIndex = 4;
            this.butGiamSat.Text = "Tổ giám sát";
            this.butGiamSat.UseVisualStyleBackColor = true;
            // 
            // btXemTB
            // 
            this.btXemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemTB.Location = new System.Drawing.Point(79, 400);
            this.btXemTB.Margin = new System.Windows.Forms.Padding(2);
            this.btXemTB.Name = "btXemTB";
            this.btXemTB.Size = new System.Drawing.Size(401, 59);
            this.btXemTB.TabIndex = 5;
            this.btXemTB.Text = "Xem thông báo";
            this.btXemTB.UseVisualStyleBackColor = true;
            this.btXemTB.Click += new System.EventHandler(this.btXemTB_Click);
            // 
            // btTTCaNhan
            // 
            this.btTTCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTTCaNhan.Location = new System.Drawing.Point(79, 478);
            this.btTTCaNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btTTCaNhan.Name = "btTTCaNhan";
            this.btTTCaNhan.Size = new System.Drawing.Size(401, 72);
            this.btTTCaNhan.TabIndex = 6;
            this.btTTCaNhan.Text = "Xem thông tin cá nhân";
            this.btTTCaNhan.UseVisualStyleBackColor = true;
            this.btTTCaNhan.Click += new System.EventHandler(this.btTTCaNhan_Click);
            // 
            // FormBanTochuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 561);
            this.Controls.Add(this.btTTCaNhan);
            this.Controls.Add(this.btXemTB);
            this.Controls.Add(this.butGiamSat);
            this.Controls.Add(this.butTheoDoiKQ);
            this.Controls.Add(this.butNguoiDiBau);
            this.Controls.Add(this.butDSUngVien);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBanTochuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btXemTB;
        private System.Windows.Forms.Button btTTCaNhan;
    }
}