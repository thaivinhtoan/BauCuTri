namespace QuanLyBinhBauTinNhiem
{
    partial class FormNguoiDiBau
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
            this.btBauChon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btXemThongBao = new System.Windows.Forms.Button();
            this.btXemThongTinCaNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBauChon
            // 
            this.btBauChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBauChon.Location = new System.Drawing.Point(59, 99);
            this.btBauChon.Margin = new System.Windows.Forms.Padding(2);
            this.btBauChon.Name = "btBauChon";
            this.btBauChon.Size = new System.Drawing.Size(173, 71);
            this.btBauChon.TabIndex = 1;
            this.btBauChon.Text = "BẦU CHỌN";
            this.btBauChon.UseVisualStyleBackColor = true;
            this.btBauChon.Click += new System.EventHandler(this.btBauChon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "BẦU CỬ";
            // 
            // btXemThongBao
            // 
            this.btXemThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemThongBao.Location = new System.Drawing.Point(59, 199);
            this.btXemThongBao.Margin = new System.Windows.Forms.Padding(2);
            this.btXemThongBao.Name = "btXemThongBao";
            this.btXemThongBao.Size = new System.Drawing.Size(173, 71);
            this.btXemThongBao.TabIndex = 2;
            this.btXemThongBao.Text = "XEM THÔNG BÁO";
            this.btXemThongBao.UseVisualStyleBackColor = true;
            this.btXemThongBao.Click += new System.EventHandler(this.btXemThongBao_Click);
            // 
            // btXemThongTinCaNhan
            // 
            this.btXemThongTinCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemThongTinCaNhan.Location = new System.Drawing.Point(59, 308);
            this.btXemThongTinCaNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btXemThongTinCaNhan.Name = "btXemThongTinCaNhan";
            this.btXemThongTinCaNhan.Size = new System.Drawing.Size(173, 71);
            this.btXemThongTinCaNhan.TabIndex = 3;
            this.btXemThongTinCaNhan.Text = "XEM THÔNG TIN CÁ NHÂN";
            this.btXemThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btXemThongTinCaNhan.Click += new System.EventHandler(this.btXemThongTinCaNhan_Click);
            // 
            // FormNguoiDiBau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXemThongTinCaNhan);
            this.Controls.Add(this.btXemThongBao);
            this.Controls.Add(this.btBauChon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormNguoiDiBau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBauChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXemThongBao;
        private System.Windows.Forms.Button btXemThongTinCaNhan;
    }
}