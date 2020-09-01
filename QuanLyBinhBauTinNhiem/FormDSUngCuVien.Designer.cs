namespace QuanLyBinhBauTinNhiem
{
    partial class FormDSUngCuVien
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btBauChon = new System.Windows.Forms.Button();
            this.lvBauChon = new System.Windows.Forms.ListView();
            this.lvUngVien = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "DS ỨNG CỬ VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "DS THÀNH VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "QUẢN LÝ DANH SÁCH ỨNG CỬ VIÊN";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(118, 321);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(173, 37);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "CHỌN";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(435, 321);
            this.btRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(173, 37);
            this.btRemove.TabIndex = 11;
            this.btRemove.Text = "BỎ CHỌN";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // btBauChon
            // 
            this.btBauChon.BackColor = System.Drawing.Color.DarkOrange;
            this.btBauChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBauChon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBauChon.Location = new System.Drawing.Point(259, 373);
            this.btBauChon.Margin = new System.Windows.Forms.Padding(2);
            this.btBauChon.Name = "btBauChon";
            this.btBauChon.Size = new System.Drawing.Size(242, 53);
            this.btBauChon.TabIndex = 12;
            this.btBauChon.Text = "XÁC NHẬN ";
            this.btBauChon.UseVisualStyleBackColor = false;
            // 
            // lvBauChon
            // 
            this.lvBauChon.HideSelection = false;
            this.lvBauChon.Location = new System.Drawing.Point(395, 89);
            this.lvBauChon.Name = "lvBauChon";
            this.lvBauChon.Size = new System.Drawing.Size(274, 227);
            this.lvBauChon.TabIndex = 8;
            this.lvBauChon.UseCompatibleStateImageBehavior = false;
            // 
            // lvUngVien
            // 
            this.lvUngVien.HideSelection = false;
            this.lvUngVien.Location = new System.Drawing.Point(58, 89);
            this.lvUngVien.Name = "lvUngVien";
            this.lvUngVien.Size = new System.Drawing.Size(289, 227);
            this.lvUngVien.TabIndex = 9;
            this.lvUngVien.UseCompatibleStateImageBehavior = false;
            // 
            // FormDSUngCuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btBauChon);
            this.Controls.Add(this.lvBauChon);
            this.Controls.Add(this.lvUngVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDSUngCuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDSUngCuVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btBauChon;
        private System.Windows.Forms.ListView lvBauChon;
        private System.Windows.Forms.ListView lvUngVien;
    }
}