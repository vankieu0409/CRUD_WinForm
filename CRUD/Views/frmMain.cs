using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.IServices;
using CRUD.models;
using CRUD.Services;

namespace CRUD.Views
{
    public partial class frmMain : Form
    {
        private bool STT;
        private IServicesAccount _servicesAccount;
        private IServiceFile _serviceFile;
        private string _fileNamePath;
        private List<Accounts> _lstAccounts;
        private Accounts accounts;
        public frmMain()
        {
            InitializeComponent();
            _serviceFile = new SerViceFiles();
            _servicesAccount = new ServicesAcounts();
            _lstAccounts = new List<Accounts>();
            rbt_Nam.Checked = true;
            cbx_khd.Checked = true;
            loadNamSinh();
        }
        void loadNamSinh()
        {
            foreach (var VARIABLE in _servicesAccount.getYearofBirth())
            {
                combx_namsinh.Items.Add(VARIABLE);
            }
        }

        void LoadDaTa()
        {
            _lstAccounts = new List<Accounts>();// khởi tạo lại
            _lstAccounts = _servicesAccount.getlst();// đổ dữ liệu vài lis Hiện tại
            //dếm thuộc tính có trong đối tượng
            Type type = typeof(Accounts);
            int SLthuoctinh = type.GetProperties().Length;
            gv_data.ColumnCount = SLthuoctinh + 1;
            gv_data.Columns[0].Name = " Tài khoản";
            gv_data.Columns[1].Name = " Mật Khẩu";
            gv_data.Columns[2].Name = " Giới tính";
            gv_data.Columns[3].Name = " Năm Sinh";
            gv_data.Columns[4].Name = " Trạng thái";
            gv_data.Columns[5].Name = " Tuổi";
            gv_data.Columns[6].Name = " ID";
            gv_data.Rows.Clear();
            foreach (var x in _lstAccounts)
            {
                gv_data.Rows.Add(x.Acc, x.Pass, x.Sex == 1 ? "Nam" : x.Sex == 0 ? "Nữ" : "",
                    x.YearofBirth, x.Status == true ? "Hoạt Động" : "Không Hoạt Động",DateTime.Now.Year-x.YearofBirth,x.Id);
            }


        }
        public void SenderfilenamePathFormLogin(TextBox txtAcc,string duongDanFile)
        {
            _fileNamePath = duongDanFile; // gán đường dẫn từ form login sang bên đăng ký
            _servicesAccount.fillDataFormtoService(_serviceFile.OpenFile<Accounts>(duongDanFile));
            LoadDaTa();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts();
            accounts.Id = _lstAccounts == null ? 1 : _lstAccounts.Count; // Id tự sinh
            accounts.Acc = tbx_tk.Text;
            accounts.Pass = tbx_mk.Text;
            accounts.Sex = rbt_Nam.Checked ? 1 : 0;
            accounts.YearofBirth = Convert.ToInt16((combx_namsinh.SelectedItem));
            accounts.Status = cbx_khd.Checked?false:true;
            //Sau khi gán thì dùng chứ năng thêm đối tượng
            _servicesAccount.addAccount(accounts);
            // sau Khi thêm xong thì tiến hành load data
            LoadDaTa();
        }

        private void cbx_hd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_hd.Checked)
            {
                cbx_khd.Checked = false;
            }
        }

        private void cbx_khd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_khd.Checked)
            {
                cbx_hd.Checked = false;
            }
        }

        private void mn_luuFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_serviceFile.SaveFile(_fileNamePath, _lstAccounts), " thông báo");
        }

        /*  void loadNawmSinh()
          {
              string[] arrNawmSinh = new string[2021 - 1600];
              int temp = 1600;
              for (int i = 0; i < arrNawmSinh.Length; i++)
              {
                  //    arrNawmSinh[i] = Convert.ToString(temp);
                  combx_namsinh.Items.Add(temp);
                  temp++;
              }
          }

          void gridview()
          {
              gv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
              gv_data.ColumnCount = 5;
              gv_data.Columns[0].Name = " Tài khoản";
              gv_data.Columns[1].Name = " Mật Khẩu";
              gv_data.Columns[2].Name = " Giới tính";
              gv_data.Columns[3].Name = " Năm Sinh";
              gv_data.Columns[4].Name = " Trạng thái";
              foreach (var x in _servicesAccount.getlst())
              {
                  gv_data.Rows.Add(x.Acc, x.Pass, x.Sex == 1 ? "Nam" : x.Sex == 0 ? "Nữ" : "", x.YearofBirth, x.Status == true ? "Hoạt Động" : "Không Hoạt Động");
              }


          }
          private void btn_automk_Click(object sender, EventArgs e)
          {

              Random auto = new Random();
              tbx_mk.Text = Convert.ToString(auto.Next());
          }


          private void rbt_Nam_CheckedChanged(object sender, EventArgs e)
          {
              gioitinh = 1;
          }

          private void rbt_Nu_CheckedChanged(object sender, EventArgs e)
          {
              gioitinh = 0;
          }

          private void cbx_hd_CheckedChanged(object sender, EventArgs e)
          {
              if (cbx_hd.Checked)
              {
                  cbx_khd.Checked == false;
              }
          }

          private void cbx_khd_CheckedChanged(object sender, EventArgs e)
          {
              STT = false;
          }
         /* private void btn_them_Click(object sender, EventArgs e)
          {

              string ten = tbx_tk.Text;
              string mk = tbx_mk.Text;
              int sex = gioitinh;
              int namSinh = Convert.ToInt16(combx_namsinh.Text);
              bool STT = Stt;

             // pt.Add(ten, mk, sex, namSinh, STT);
              MessageBox.Show("thêm thành Công", " thông báo");


          }


          private void lưuFileToolStripMenuItem_Click(object sender, EventArgs e)
          {
              SaveFileDialog save = new SaveFileDialog();
              save.Title = "Chọn đường dẫn file lưu";
              if (save.ShowDialog() == DialogResult.OK)
              {
                  StringBuilder sb = new StringBuilder();
                  foreach (var sv in _servicesAccount.getlst())
                  {
                      sb.AppendLine(sv.ToString());
                  }

                  File.WriteAllText(save.FileName, sb.ToString());
              }
          }*/
    }
}

