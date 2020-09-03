using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBinhBauTinNhiem
{
    public partial class FormBanTochuc : Form
    {
        ThanhVien thanhVien;
        public FormBanTochuc(ThanhVien tv)
        {
            InitializeComponent();
            thanhVien = tv;
        }

        private void btXemTB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formThongBao = new FormThongBao(thanhVien);
            formThongBao.ShowDialog();
            this.Show();
        }

        private void btTTCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formThongTinCaNhan = new FormThongTinCaNhan(thanhVien);
            formThongTinCaNhan.ShowDialog();
            this.Show();
        }

        private void butDSUngVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formXemDSUngVien = new FormXemDSUngVien(thanhVien);
            formXemDSUngVien.ShowDialog();
            this.Show();
        }
    }
}
