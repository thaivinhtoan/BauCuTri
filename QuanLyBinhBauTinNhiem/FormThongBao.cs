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
    public partial class FormThongBao : Form
    {
        ThanhVien ThanhVien;
        BLL.BLL bll =  new BLL.BLL();
        List<ThongBao> thongBaos = new List<ThongBao>();
        public FormThongBao(ThanhVien TV)
        {
            InitializeComponent();
            LoadListView(lvThongBao);
            ThanhVien = TV;
        }

        void LoadListView(ListView listView)
        {
            listView.BeginUpdate();
            listView.Clear();
            var width = listView.Width;
            listView.Columns.Add("THÔNG BÁO", (int)(1 * width));
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.LabelEdit = true;
            listView.EndUpdate();
        }

        private void FormThongBao_Load(object sender, EventArgs e)
        {
            thongBaos = bll.GetThongBaos(ThanhVien);
            foreach (var i in thongBaos)
            {
                lvThongBao.Items.Add(i.noidung);
            }
        }
    }
}
