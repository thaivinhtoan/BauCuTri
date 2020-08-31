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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        
        //ThanhVien current_tv = new ThanhVien();
        private void butLogin_Click(object sender, EventArgs e)
        {

            ThanhVien current_tv = new ThanhVien(txbUserName.Text, txbPassword.Text);
            current_tv = new BLL.BLL().Login(current_tv);

            if (current_tv.VAITRO == "TRUONG BAN TO CHUC")
            {
                this.Hide();
                fBanTochuc f = new fBanTochuc();
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




            //current_tv.USERNAME = txbUserName.Text;
            //current_tv.password = txbPassword.Text;
            //current_tv = new BLL.BLL().Login(current_tv);
            //if (current_tv.VAITRO == "TRUONG BAN TO CHUC")
            //{
            //    this.Hide();
            //    fBanTochuc f = new fBanTochuc();
            //    f.ShowDialog();
            //    this.Close();
            //}

            //else
            //{
            //    this.Show();
            //    MessageBox.Show("Invalid username or password!");
            //    this.txbUserName.Text = "";
            //    this.txbPassword.Text = "";
            //}

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
