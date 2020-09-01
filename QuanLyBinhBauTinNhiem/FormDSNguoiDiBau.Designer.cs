namespace QuanLyBinhBauTinNhiem
{
    partial class FormDSNguoiDiBau
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
            this.lvDsNguoiDiBau = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "DS NGƯỜI ĐI BẦU";
            // 
            // lvDsNguoiDiBau
            // 
            this.lvDsNguoiDiBau.HideSelection = false;
            this.lvDsNguoiDiBau.Location = new System.Drawing.Point(28, 63);
            this.lvDsNguoiDiBau.Name = "lvDsNguoiDiBau";
            this.lvDsNguoiDiBau.Size = new System.Drawing.Size(318, 375);
            this.lvDsNguoiDiBau.TabIndex = 9;
            this.lvDsNguoiDiBau.UseCompatibleStateImageBehavior = false;
            // 
            // FormDSNguoiDiBau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.lvDsNguoiDiBau);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDSNguoiDiBau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDSNguoiDiBau";
            this.Load += new System.EventHandler(this.FormDSNguoiDiBau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDsNguoiDiBau;
    }
}