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
    public partial class FormDSNguoiDiBau : Form
    {
        ThanhVien thanhVien;
        BLL.BLL bll = new BLL.BLL();
        List<DSBauCu> dSBauCus = new List<DSBauCu>();
        public FormDSNguoiDiBau(ThanhVien tv)
        {
            InitializeComponent();
            thanhVien = tv;
            LoadListView(lvDsNguoiDiBau);
        }

        void LoadListView(ListView listView)
        {
            listView.BeginUpdate();
            listView.Clear();
            var width = listView.Width;
            listView.Columns.Add("HỌ VÀ TÊN", (int)(1 * width));
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.LabelEdit = true;
            listView.EndUpdate();
        }

        private void FormDSNguoiDiBau_Load(object sender, EventArgs e)
        {
            dSBauCus = bll.GetDSBauCus(thanhVien);
            foreach (var i in dSBauCus)
            {
                var row = new ListViewItem()
                {
                    Text = i.name.ToString(),
                    Tag = i
                };
                lvDsNguoiDiBau.Items.Add(row);
            }
        }
    }
}
