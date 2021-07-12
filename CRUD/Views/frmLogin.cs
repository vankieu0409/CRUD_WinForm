using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.IServices;
using CRUD.models;
using CRUD.Services;

namespace CRUD.Views
{
    public partial class frmLogin : Form
    {
        private IServicesAccount _servicesAccount;
        private IServiceFile _serviceFile;
        private string _fileNamePath;
        private List<Accounts> _lstAccounts;

        public frmLogin()
        {
            _serviceFile = new SerViceFiles();
            _servicesAccount = new ServicesAcounts();
            InitializeComponent();
        }
        

        private void btn_login_Click(object sender, EventArgs e)
        {
            //    if (tbx_tk.Text == "kieu" && tbx_mk.Text == "1")
            //    {
            //        frmMain a = new frmMain();
            //        this.Hide();
            //        a.ShowDialog();
            //        this.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Bạn Nhập Sai Tài khỏn hoặc Mật khẩu!\n Mời Nhập lại", "THÔNG BÁO");
            //        return;
            //    }

            lbl_checkdata.Text = _servicesAccount.getlst().Count.ToString();
            if (string.IsNullOrWhiteSpace(tbx_tk.Text)|| string.IsNullOrWhiteSpace(tbx_mk.Text) )
            {
                MessageBox.Show(" Không đƯợc để trống Tài Khoản Và Mật Khẩu", " Erorr 400");
                return;
            }
            if (_servicesAccount.getlst().Where(c => c.Acc == tbx_tk.Text && c.Pass == tbx_mk.Text) != null)
            {
                MessageBox.Show("Đăng Nhâp thành công", "Thông Bấu");
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Show();
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

        private void btn_Data_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _fileNamePath = dlg.FileName; // gán Lại đương dẫn của File cho biến
                lbl_fileNamePath.Text = _fileNamePath;
                _lstAccounts = _serviceFile.OpenFile<Accounts>(_fileNamePath);// đọc file lên và lấy giá trị gán lại cho List
                _servicesAccount.fillDataFormtoService(_lstAccounts);// Đổ giá trị vào cho List ở bên AccountService
                lbl_checkdata.Text = (_servicesAccount.getlst()==null?0:_servicesAccount.getlst().Count).ToString();
            }
        }

        private void lbl_dk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.SenderfilenamePathFormLogin(
                _fileNamePath); // gọi phương thức bên claas đăng ký và truyền đường dẫn sang để gấn lại;
            this.Hide();
            frmRegister.Show();
        }
    }
}