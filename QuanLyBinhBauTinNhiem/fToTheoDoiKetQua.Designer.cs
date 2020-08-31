namespace QuanLyBinhBauTinNhiem
{
    partial class fToTheoDoiKetQua
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
            this.butDsNgDiBau = new System.Windows.Forms.Button();
            this.butSLBB = new System.Windows.Forms.Button();
            this.butTB = new System.Windows.Forms.Button();
            this.butTTCN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butDsNgDiBau
            // 
            this.butDsNgDiBau.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDsNgDiBau.Location = new System.Drawing.Point(183, 75);
            this.butDsNgDiBau.Name = "butDsNgDiBau";
            this.butDsNgDiBau.Size = new System.Drawing.Size(421, 104);
            this.butDsNgDiBau.TabIndex = 0;
            this.butDsNgDiBau.Text = "Xem DS người đi bầu";
            this.butDsNgDiBau.UseVisualStyleBackColor = true;
            // 
            // butSLBB
            // 
            this.butSLBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSLBB.Location = new System.Drawing.Point(183, 204);
            this.butSLBB.Name = "butSLBB";
            this.butSLBB.Size = new System.Drawing.Size(421, 104);
            this.butSLBB.TabIndex = 1;
            this.butSLBB.Text = "Xem số lần bình bầu từng ứng viên";
            this.butSLBB.UseVisualStyleBackColor = true;
            // 
            // butTB
            // 
            this.butTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTB.Location = new System.Drawing.Point(183, 328);
            this.butTB.Name = "butTB";
            this.butTB.Size = new System.Drawing.Size(421, 102);
            this.butTB.TabIndex = 2;
            this.butTB.Text = "Xem thông báo";
            this.butTB.UseVisualStyleBackColor = true;
            // 
            // butTTCN
            // 
            this.butTTCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTTCN.Location = new System.Drawing.Point(183, 449);
            this.butTTCN.Name = "butTTCN";
            this.butTTCN.Size = new System.Drawing.Size(421, 101);
            this.butTTCN.TabIndex = 3;
            this.butTTCN.Text = "Xem thông tin cá nhân";
            this.butTTCN.UseVisualStyleBackColor = true;
            // 
            // fToTheoDoiKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 658);
            this.Controls.Add(this.butTTCN);
            this.Controls.Add(this.butTB);
            this.Controls.Add(this.butSLBB);
            this.Controls.Add(this.butDsNgDiBau);
            this.Name = "fToTheoDoiKetQua";
            this.Text = "fToTheoDoiKetQua";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butDsNgDiBau;
        private System.Windows.Forms.Button butSLBB;
        private System.Windows.Forms.Button butTB;
        private System.Windows.Forms.Button butTTCN;
    }
}