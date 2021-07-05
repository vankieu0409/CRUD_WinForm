using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void lbl_Quenmk_MouseClick(object sender, MouseEventArgs e)
        {

            frmMain a = new frmMain();
            a.Show();
        }

        private void lbl_dk_MouseClick(object sender, MouseEventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tbx_tk.Text == "kieu" && tbx_mk.Text == "1")
            {
                frmMain a = new frmMain();
                this.Hide();
                a.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn Nhập Sai Tài khỏn hoặc Mật khẩu!\n Mời Nhập lại", "THÔNG BÁO");
                return;
            }

        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) !=
                System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
