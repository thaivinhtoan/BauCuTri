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
    public partial class FormThongTinCaNhan : Form
    {
        BLL.BLL bll = new BLL.BLL();
        ThanhVien ThanhVien;
        public FormThongTinCaNhan(ThanhVien tv)
        {
            InitializeComponent();
            ThanhVien = tv;
        }

        private void FormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            ThongTinCaNhan thongTinCaNhan = bll.GetThongTinCaNhan(ThanhVien);
            lbHoVaTen.Text = thongTinCaNhan.HoVaTen;
            lbGioitinh.Text = thongTinCaNhan.Phai;
            lbQueQuan.Text = thongTinCaNhan.QueQuan;
            lbNgaySinh.Text = thongTinCaNhan.Ngaysinh;
            lbQuocTich.Text= thongTinCaNhan.QuocTich;
            lbDiaChiThuongTru.Text= thongTinCaNhan.DiaChiThuongTru;
            lbDiaChiTamTru.Text = thongTinCaNhan.DiaChiTamTru;
            lbVaiTRo.Text = thongTinCaNhan.VaiTro;
            lbMaDonVi.Text = thongTinCaNhan.MaDonVi.ToString();
            lbViTriCongTac.Text= thongTinCaNhan.ViTriCongTac;
            lbNghiPhep.Text = thongTinCaNhan.NghiPhep;
            lbLyDoNghiPhep.Text = thongTinCaNhan.LyDoNghiPhep;
            lbUserName.Text = thongTinCaNhan.UserName;
            lbMaLinhVuc.Text = thongTinCaNhan.MaLinhVuc.ToString();
        }
    }
}
