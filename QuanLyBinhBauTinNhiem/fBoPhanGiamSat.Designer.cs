namespace QuanLyBinhBauTinNhiem
{
    partial class fBoPhanGiamSat
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
            this.butDSUngVien = new System.Windows.Forms.Button();
            this.butDSThanhVien = new System.Windows.Forms.Button();
            this.butTB = new System.Windows.Forms.Button();
            this.butTTCN = new System.Windows.Forms.Button();
            this.butBC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butDSUngVien
            // 
            this.butDSUngVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDSUngVien.Location = new System.Drawing.Point(159, 67);
            this.butDSUngVien.Name = "butDSUngVien";
            this.butDSUngVien.Size = new System.Drawing.Size(433, 100);
            this.butDSUngVien.TabIndex = 0;
            this.butDSUngVien.Text = "Xem danh sách ứng viên";
            this.butDSUngVien.UseVisualStyleBackColor = true;
            // 
            // butDSThanhVien
            // 
            this.butDSThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDSThanhVien.Location = new System.Drawing.Point(159, 196);
            this.butDSThanhVien.Name = "butDSThanhVien";
            this.butDSThanhVien.Size = new System.Drawing.Size(433, 98);
            this.butDSThanhVien.TabIndex = 1;
            this.butDSThanhVien.Text = "Xem danh sách thành viên";
            this.butDSThanhVien.UseVisualStyleBackColor = true;
            // 
            // butTB
            // 
            this.butTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTB.Location = new System.Drawing.Point(159, 320);
            this.butTB.Name = "butTB";
            this.butTB.Size = new System.Drawing.Size(433, 90);
            this.butTB.TabIndex = 2;
            this.butTB.Text = "Xem thông báo\r\n";
            this.butTB.UseVisualStyleBackColor = true;
            // 
            // butTTCN
            // 
            this.butTTCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTTCN.Location = new System.Drawing.Point(159, 434);
            this.butTTCN.Name = "butTTCN";
            this.butTTCN.Size = new System.Drawing.Size(433, 93);
            this.butTTCN.TabIndex = 3;
            this.butTTCN.Text = "Xem thông tin cá nhân";
            this.butTTCN.UseVisualStyleBackColor = true;
            // 
            // butBC
            // 
            this.butBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBC.Location = new System.Drawing.Point(159, 547);
            this.butBC.Name = "butBC";
            this.butBC.Size = new System.Drawing.Size(433, 93);
            this.butBC.TabIndex = 4;
            this.butBC.Text = "Xem thông tin bầu chọn";
            this.butBC.UseVisualStyleBackColor = true;
            // 
            // fBoPhanGiamSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 733);
            this.Controls.Add(this.butBC);
            this.Controls.Add(this.butTTCN);
            this.Controls.Add(this.butTB);
            this.Controls.Add(this.butDSThanhVien);
            this.Controls.Add(this.butDSUngVien);
            this.Name = "fBoPhanGiamSat";
            this.Text = "fBoPhanGiamSat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butDSUngVien;
        private System.Windows.Forms.Button butDSThanhVien;
        private System.Windows.Forms.Button butTB;
        private System.Windows.Forms.Button butTTCN;
        private System.Windows.Forms.Button butBC;
    }
}