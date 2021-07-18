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
    public partial class frmRegister : Form
    {
        private ICheck checkEveryThings;
        private IServicesAccount _servicesAccount;
        private IServiceFile _serviceFile;
        private string _fileNamePath;
        private List<Accounts> _lstAccounts;


        public frmRegister()
        {
            InitializeComponent();
            //khởi tạo
            _serviceFile = new SerViceFiles();
            _servicesAccount = new ServicesAcounts();
            checkEveryThings = new CheckEveryThing();
            rbtn_nam.Checked = true;
            loadNamSinh();
            _lstAccounts = new List<Accounts>();
            cbx_Namsinh.SelectedIndex = cbx_Namsinh.Items.Count - 20;
        }

        void loadNamSinh()
        {
            foreach (var VARIABLE in _servicesAccount.getYearofBirth())
            {
                cbx_Namsinh.Items.Add(VARIABLE);
            }
        }

        bool check()
        {
            if (checkEveryThings.checkNull(tbx_tk.Text) || checkEveryThings.checkNull(tbx_mk.Text))
            {
                MessageBox.Show(" Không đƯợc để trống Tài Khoản Và Mật Khẩu", " Erorr 400");
                return false;
            }

            if (checkEveryThings.CheckAcc(tbx_tk.Text) == false)
            {
                MessageBox.Show("Tên Tài Khoản Phải có cả chữ số", " Erorr 400");
                return false;
            }

            if (checkEveryThings.checkMK(tbx_mk.Text) == false)
            {
                MessageBox.Show("Mật khẩu phải có 3 ký tự trở lên", " Erorr 400");
                return false;
            }
            if (checkEveryThings.CheckYearofBirth(cbx_Namsinh.Text) == false)
            {
                MessageBox.Show("Năm Sinh không đượcc nhập chữ", " Erorr 400");
                return false;
            }

            return true;
        }


        private void btn_tusinhmk_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            tbx_mk.Text = Convert.ToString(n.Next());
        }


        //private void btn_tusinhmk_Click(object sender, EventArgs e)
        //{
        //    Random n = new Random();
        //    tbx_mk.Text = Convert.ToString(n.Next());
        //}

        //private void btn_ShowPass_MouseDown(object sender, MouseEventArgs e)
        //{
        //    
        //}

        //private void btn_ShowPass_MouseUp(object sender, MouseEventArgs e)
        //{
        //    tbx_mk.PasswordChar = '*';
        //}

        public void SenderfilenamePathFormLogin(string Path)
        {
            _fileNamePath = Path; // gán đường dẫn từ form login sang bên đăng ký
        }

        void loadData()
        {
            if (_serviceFile.OpenFile<Accounts>(_fileNamePath) != null)
            {
                _lstAccounts = _serviceFile.OpenFile<Accounts>(_fileNamePath);
                return;
            }

            _lstAccounts = new List<Accounts>();
        }

        private void btn_Taotk_Click(object sender, EventArgs e)
        {
            if (check() != false)
            {
                loadData(); //đọc data từ file trước;
                Accounts accounts = new Accounts();
                accounts.Id = _lstAccounts == null ? 1 : _lstAccounts.Count; // Id tự sinh
                accounts.Acc = tbx_tk.Text;
                accounts.Pass = tbx_mk.Text;
                accounts.Sex = rbtn_nam.Checked ? 1 : 0;
                accounts.YearofBirth = Convert.ToInt16((cbx_Namsinh.SelectedItem));
                _lstAccounts.Add(accounts);
                string temp = _serviceFile.SaveFile(_fileNamePath, _lstAccounts);
                MessageBox.Show(temp, " thông báo");
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }

        private void btn_ShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            tbx_mk.PasswordChar = '\0';
        }

        private void btn_ShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            tbx_mk.PasswordChar = '*';
        }
    }
}