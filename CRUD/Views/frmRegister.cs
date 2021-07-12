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
            loadData(); //đọc data từ file trước;
            Accounts accounts = new Accounts();
            accounts.Id = _lstAccounts == null ? 1 : _lstAccounts.Count; // Id tự sinh
            accounts.Acc = tbx_tk.Text;
            accounts.Pass = tbx_mk.Text;
            accounts.Sex = rbtn_nam.Checked ? 1 : 0;
            accounts.YearofBirth = Convert.ToInt16((cbx_Namsinh.SelectedItem));
            
            MessageBox.Show(accounts.Acc+accounts.Id+accounts.Status+accounts.Pass+accounts.Sex+accounts.YearofBirth+accounts.Status+" "+ _lstAccounts, "thông báo");
            _lstAccounts.Add(accounts);
            string temp = _serviceFile.SaveFile(_fileNamePath, _lstAccounts);
            MessageBox.Show(temp, " thông báo");
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
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