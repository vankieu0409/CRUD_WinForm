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
            cbx_Namsinh.SelectedIndex = cbx_Namsinh.Items.Count - 20;
        }

        void loadNamSinh()
        {
            foreach (var x in _servicesAccount.getYearofBirth())
            {
                cbx_Namsinh.Items.Add(x);
            }
        }
        private void btn_tusinhmk_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            tbx_mk.Text = Convert.ToString(n.Next());
        }

        private void btn_ShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            tbx_mk.PasswordChar = '\0';
        }

        private void btn_ShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            tbx_mk.PasswordChar = '*';
        }

        private void cbx_Namsinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void loadNamSinh()
        {
            string[] arrNawmSinh = new string[2021 - 1900];
            int temp = 1900;
            for (int i = 0; i < arrNawmSinh.Length; i++)
            {
                //    arrNawmSinh[i] = Convert.ToString(temp);
                cbx_Namsinh.Items.Add(temp);
                temp++;
            }
        }

        public void SenderfilenamePathFormLogin(string Path)
        {
            _fileNamePath = Path;// gán đường dẫn từ form login
        }

        void loadData()
        {
            _lstAccounts = _serviceFile.OpenFile<Accounts>(_fileNamePath);
        }

        private void btn_Taotk_Click(object sender, EventArgs e)
        {
           loadData();//đọc data từ file trước;
           Accounts accounts = new Accounts();
           accounts.Id = _lstAccounts == null ? 1 : _lstAccounts.Count;
           accounts.Acc = textBox1;
            accounts.Sex = rbtn_nam.Checked ? 1 : 0;
            accounts.YearofBirth= ( )
        }
    }
}
