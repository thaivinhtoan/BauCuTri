namespace QuanLyBinhBauTinNhiem
{
    partial class fNguoiDiBau
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
            this.butDSNgDiBau = new System.Windows.Forms.Button();
            this.butXemTB = new System.Windows.Forms.Button();
            this.butTTCaNhan = new System.Windows.Forms.Button();
            this.combbDonVi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn vị\r\n";
            // 
            // butDSNgDiBau
            // 
            this.butDSNgDiBau.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDSNgDiBau.Location = new System.Drawing.Point(158, 113);
            this.butDSNgDiBau.Name = "butDSNgDiBau";
            this.butDSNgDiBau.Size = new System.Drawing.Size(388, 80);
            this.butDSNgDiBau.TabIndex = 1;
            this.butDSNgDiBau.Text = "Lập DS người đi bầu\r\n";
            this.butDSNgDiBau.UseVisualStyleBackColor = true;
            // 
            // butXemTB
            // 
            this.butXemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXemTB.Location = new System.Drawing.Point(158, 236);
            this.butXemTB.Name = "butXemTB";
            this.butXemTB.Size = new System.Drawing.Size(388, 86);
            this.butXemTB.TabIndex = 2;
            this.butXemTB.Text = "Xem thông báo";
            this.butXemTB.UseVisualStyleBackColor = true;
            // 
            // butTTCaNhan
            // 
            this.butTTCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTTCaNhan.Location = new System.Drawing.Point(158, 362);
            this.butTTCaNhan.Name = "butTTCaNhan";
            this.butTTCaNhan.Size = new System.Drawing.Size(388, 86);
            this.butTTCaNhan.TabIndex = 3;
            this.butTTCaNhan.Text = "Thông tin cá nhân";
            this.butTTCaNhan.UseVisualStyleBackColor = true;
            this.butTTCaNhan.Click += new System.EventHandler(this.button3_Click);
            // 
            // combbDonVi
            // 
            this.combbDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combbDonVi.FormattingEnabled = true;
            this.combbDonVi.Location = new System.Drawing.Point(552, 66);
            this.combbDonVi.Name = "combbDonVi";
            this.combbDonVi.Size = new System.Drawing.Size(244, 33);
            this.combbDonVi.TabIndex = 4;
            // 
            // fNguoiDiBau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.combbDonVi);
            this.Controls.Add(this.butTTCaNhan);
            this.Controls.Add(this.butXemTB);
            this.Controls.Add(this.butDSNgDiBau);
            this.Controls.Add(this.label1);
            this.Name = "fNguoiDiBau";
            this.Text = "fNguoiDiBau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDSNgDiBau;
        private System.Windows.Forms.Button butXemTB;
        private System.Windows.Forms.Button butTTCaNhan;
        private System.Windows.Forms.ComboBox combbDonVi;
    }
}