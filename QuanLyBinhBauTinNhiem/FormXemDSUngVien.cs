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
    public partial class FormXemDSUngVien : Form
    {
        ThanhVien thanhVien;
        BLL.BLL bll = new BLL.BLL();
        DSUngVien[] dsUngViens ;
        public FormXemDSUngVien(ThanhVien tv)
        {
            InitializeComponent();
            thanhVien = tv;
            LoadListView(lvDsUngVien);
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

        private void FormXemDSUngVien_Load(object sender, EventArgs e)
        {
            dsUngViens = bll.GetDSUngViens(thanhVien);
            foreach (var i in dsUngViens)
            {
                var row = new ListViewItem()
                {
                    Text = i.name.ToString(),
                    Tag = i
                };
                lvDsUngVien.Items.Add(row);
            }
        }
    }
}
