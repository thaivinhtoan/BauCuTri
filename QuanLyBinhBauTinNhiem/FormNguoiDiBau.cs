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
    public partial class FormNguoiDiBau : Form
    {
        ThanhVien thanhVien;
        public FormNguoiDiBau(ThanhVien tv)
        {
            InitializeComponent();
            thanhVien = tv;
        }

        private void btBauChon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBauChon = new FormBauChon(thanhVien);
            formBauChon.ShowDialog();
            this.Show();
        }

        private void btXemThongTinCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formThongTinCaNhan = new FormThongTinCaNhan(thanhVien);
            formThongTinCaNhan.ShowDialog();
            this.Show();
        }

        private void btXemThongBao_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formThongBao = new FormThongBao(thanhVien);
            formThongBao.ShowDialog();
            this.Show();
        }
    }
}
