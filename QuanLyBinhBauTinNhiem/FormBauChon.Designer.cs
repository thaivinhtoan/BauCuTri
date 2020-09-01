namespace QuanLyBinhBauTinNhiem
{
    partial class FormBauChon
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
            this.lvUngVien = new System.Windows.Forms.ListView();
            this.lvBauChon = new System.Windows.Forms.ListView();
            this.btBauChon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvUngVien
            // 
            this.lvUngVien.HideSelection = false;
            this.lvUngVien.Location = new System.Drawing.Point(24, 89);
            this.lvUngVien.Name = "lvUngVien";
            this.lvUngVien.Size = new System.Drawing.Size(273, 227);
            this.lvUngVien.TabIndex = 0;
            this.lvUngVien.UseCompatibleStateImageBehavior = false;
            // 
            // lvBauChon
            // 
            this.lvBauChon.HideSelection = false;
            this.lvBauChon.Location = new System.Drawing.Point(345, 89);
            this.lvBauChon.Name = "lvBauChon";
            this.lvBauChon.Size = new System.Drawing.Size(274, 227);
            this.lvBauChon.TabIndex = 0;
            this.lvBauChon.UseCompatibleStateImageBehavior = false;
            // 
            // btBauChon
            // 
            this.btBauChon.BackColor = System.Drawing.Color.DarkOrange;
            this.btBauChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBauChon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btBauChon.Location = new System.Drawing.Point(209, 373);
            this.btBauChon.Margin = new System.Windows.Forms.Padding(2);
            this.btBauChon.Name = "btBauChon";
            this.btBauChon.Size = new System.Drawing.Size(242, 53);
            this.btBauChon.TabIndex = 6;
            this.btBauChon.Text = "XÁC NHẬN BẦU CỬ";
            this.btBauChon.UseVisualStyleBackColor = false;
            this.btBauChon.Click += new System.EventHandler(this.btBauChon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "BẦU CỬ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "DANH SÁCH ỨNG VIÊN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "NGƯỜI ĐƯỢC BẦU";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(68, 321);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(173, 37);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "CHỌN";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(385, 321);
            this.btRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(173, 37);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "BỎ CHỌN";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // FormBauChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(658, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btBauChon);
            this.Controls.Add(this.lvBauChon);
            this.Controls.Add(this.lvUngVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormBauChon";
            this.Text = "FormBauChon";
            this.Load += new System.EventHandler(this.FormBauChon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUngVien;
        private System.Windows.Forms.ListView lvBauChon;
        private System.Windows.Forms.Button btBauChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
    }
}