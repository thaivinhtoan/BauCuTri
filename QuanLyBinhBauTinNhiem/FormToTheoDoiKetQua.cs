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
    public partial class FormToTheoDoiKetQua : Form
    {
        ThanhVien thanhVien;
        public FormToTheoDoiKetQua(ThanhVien tv)
        {
            InitializeComponent();
            thanhVien = tv;
        }

        private void btDSNguoiDiBau_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formDSNguoiDiBau = new FormDSNguoiDiBau(thanhVien);
            formDSNguoiDiBau.ShowDialog();
            this.Show();
        }

        private void btSoLanBinhBau_Click(object sender, EventArgs e)
        {

        }

        private void btXemThongBao_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formThongBao = new FormThongBao(thanhVien);
            formThongBao.ShowDialog();
            this.Show();
        }

        private void btXemThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formThongTinCaNhan = new FormThongTinCaNhan(thanhVien);
            formThongTinCaNhan.ShowDialog();
            this.Show();
        }
    }
}
