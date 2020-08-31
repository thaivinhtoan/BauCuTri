namespace QuanLyBinhBauTinNhiem
{
    partial class fDSUngVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbMaTV = new System.Windows.Forms.TextBox();
            this.txbMaUV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGVUV = new System.Windows.Forms.DataGridView();
            this.butThem = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH ỨNG VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMaTV);
            this.groupBox1.Controls.Add(this.txbMaUV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ứng viên";
            // 
            // txbMaTV
            // 
            this.txbMaTV.Location = new System.Drawing.Point(566, 38);
            this.txbMaTV.Name = "txbMaTV";
            this.txbMaTV.Size = new System.Drawing.Size(261, 30);
            this.txbMaTV.TabIndex = 3;
            // 
            // txbMaUV
            // 
            this.txbMaUV.Location = new System.Drawing.Point(128, 38);
            this.txbMaUV.Name = "txbMaUV";
            this.txbMaUV.Size = new System.Drawing.Size(229, 30);
            this.txbMaUV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "MaTV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "MaUV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGVUV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 338);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách ứng viên";
            // 
            // dataGVUV
            // 
            this.dataGVUV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUV.Location = new System.Drawing.Point(7, 31);
            this.dataGVUV.Name = "dataGVUV";
            this.dataGVUV.RowHeadersWidth = 51;
            this.dataGVUV.RowTemplate.Height = 24;
            this.dataGVUV.Size = new System.Drawing.Size(845, 291);
            this.dataGVUV.TabIndex = 0;
            // 
            // butThem
            // 
            this.butThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThem.Location = new System.Drawing.Point(26, 584);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(138, 67);
            this.butThem.TabIndex = 3;
            this.butThem.Text = "THÊM";
            this.butThem.UseVisualStyleBackColor = true;
            // 
            // butXoa
            // 
            this.butXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXoa.Location = new System.Drawing.Point(195, 584);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(137, 67);
            this.butXoa.TabIndex = 4;
            this.butXoa.Text = "XÓA";
            this.butXoa.UseVisualStyleBackColor = true;
            // 
            // butSua
            // 
            this.butSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSua.Location = new System.Drawing.Point(364, 584);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(141, 67);
            this.butSua.TabIndex = 5;
            this.butSua.Text = "SỬA";
            this.butSua.UseVisualStyleBackColor = true;
            // 
            // fDSUngVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 663);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fDSUngVien";
            this.Text = "fDSUngVien";
            this.Load += new System.EventHandler(this.fDSUngVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMaTV;
        private System.Windows.Forms.TextBox txbMaUV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGVUV;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butSua;
    }
}