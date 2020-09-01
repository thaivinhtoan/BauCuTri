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
    public partial class FormBauChon : Form
    {
        ThanhVien thanhVien;
        DSUngVien[] dSUngViens;
        BLL.BLL bll;
        int MaTV;
        public FormBauChon(ThanhVien tv)
        {
            InitializeComponent();
            thanhVien = tv;
            bll = new BLL.BLL();
            MaTV = bll.GetMaTV(thanhVien);
            LoadListView(lvUngVien);
            LoadListView(lvBauChon);
        }
        void LoadListView(ListView listView)
        {
            listView.BeginUpdate();
            listView.Clear();
            var width = listView.Width;
            listView.Columns.Add("TÊN ỨNG VIÊN", (int)(1 * width));
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.LabelEdit = true;
            listView.EndUpdate();
        }

        private void FormBauChon_Load(object sender, EventArgs e)
        {   
            dSUngViens = bll.GetDSUngViens(thanhVien);
            foreach (var i in dSUngViens)
            {
                var row = new ListViewItem()
                {
                    Text = i.name.ToString(),
                    Tag = i
                };
                lvUngVien.Items.Add(row);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var ChoseUngViens = lvUngVien.SelectedItems;
            if (lvBauChon.Items.Count < 3)
            {

                foreach (ListViewItem choseUngVien in ChoseUngViens)
                {
                    lvUngVien.Items.Remove(choseUngVien);
                    lvBauChon.Items.Add(choseUngVien);
                }
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            var ChoseUngViens = lvBauChon.SelectedItems;

            foreach (ListViewItem choseUngVien in ChoseUngViens)
            {
                lvBauChon.Items.Remove(choseUngVien);
                lvUngVien.Items.Add(choseUngVien);
            }

        }

        List<DSUngVien> chooseUngViens()
        {
            var ungViens = new List<DSUngVien>();
            foreach(ListViewItem i in lvBauChon.Items)
            {
                ungViens.Add(i.Tag as DSUngVien);
            }
            return ungViens;
        }

        private void btBauChon_Click(object sender, EventArgs e)
        {

            if (bll.createBauChon(thanhVien, chooseUngViens()))
            {
                MessageBox.Show("BẦU CỬ THÀNH CÔNG");
            }
            else
                MessageBox.Show("THẤT BẠI");
        }
    }
}
