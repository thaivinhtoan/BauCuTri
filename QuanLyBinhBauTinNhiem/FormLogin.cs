using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace QuanLyBinhBauTinNhiem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void butLogin_Click(object sender, EventArgs e)
        {

            ThanhVien current_tv = new ThanhVien(txbUserName.Text, txbPassword.Text);
            current_tv = new BLL.BLL().Login(current_tv);

            if (current_tv.VAITRO.Contains("BAN TO CHUC"))
            {
                this.Hide();
                FormBanTochuc f = new FormBanTochuc(current_tv);
                f.ShowDialog();
                this.Show();
            }
            else
            {
                if (current_tv.VAITRO.Contains("TO LAP DANH SACH"))
                {
                    this.Hide();
                    FormToLapDanhSach  f = new FormToLapDanhSach(current_tv);
                    f.ShowDialog();
                    this.Show();

                }
                else
                {
                    if (current_tv.VAITRO.Contains("TO THEO DOI KET QUA"))
                    {
                        this.Hide();
                        var f = new FormToTheoDoiKetQua(current_tv);
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        if (current_tv.VAITRO.Contains("BO PHAN GIAM SAT"))
                        {
                            this.Hide();
                            var f = new FormBoPhanGiamSat(current_tv);
                            f.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            if (current_tv.VAITRO.Contains("NGUOI DI BAU"))
                            {
                                this.Hide();
                                FormNguoiDiBau f = new FormNguoiDiBau(current_tv);
                                f.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                this.Show();
                                MessageBox.Show("Invalid username or password!");
                                this.txbUserName.Text = "";
                                this.txbPassword.Text = "";
                            }
                        }
                    }
                }
            }
        }


        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
      
    }
}
