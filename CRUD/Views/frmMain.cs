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
        private ICheck checkEveryThings;
        private IServicesAccount _servicesAccount;
        private IServiceFile _serviceFile;
        private string _fileNamePath;
        private List<Accounts> _lstAccounts;
        private Accounts accounts;
        private int idAccWhenClick = -1;
        private int flash = 0;
        public frmMain()
        {
            InitializeComponent();
            checkEveryThings = new CheckEveryThing();
            _serviceFile = new SerViceFiles();
            _servicesAccount = new ServicesAcounts();
            _lstAccounts = new List<Accounts>();
            rbt_Nam.Checked = true;
            cbx_khd.Checked = true;
            loadNamSinh();
            //loadSan();
        }

        void loadNamSinh()
        {
            foreach (var VARIABLE in _servicesAccount.getYearofBirth())
            {
                combx_namsinh.Items.Add(VARIABLE);
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
                MessageBox.Show("Tên Tài Khoản Phải có cả chữ và số", " Erorr 400");
                return false;
            }

            if (checkEveryThings.checkMK(tbx_mk.Text) == false)
            {
                MessageBox.Show("Mật khẩu phải có 3 ký tự trở lên", " Erorr 400");
                return false;
            }
            if (checkEveryThings.CheckYearofBirth(combx_namsinh.Text) == false)
            {
                MessageBox.Show("Năm Sinh không đượcc nhập chữ", " Erorr 400");
                return false;
            }

            return true;
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
                    x.YearofBirth, x.Status == true ? "Hoạt Động" : "Không Hoạt Động", DateTime.Now.Year - x.YearofBirth, x.Id);
            }


        }
        public void SenderfilenamePathFormLogin(TextBox txtAcc, string duongDanFile)
        {
            _fileNamePath = duongDanFile; // gán đường dẫn từ form login sang bên đăng ký
            _servicesAccount.fillDataFormtoService(_serviceFile.OpenFile<Accounts>(duongDanFile));
            LoadDaTa();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (check()!=false)
            {
            
                Accounts accounts = new Accounts();
                accounts.Id = _lstAccounts == null ? 1 : _lstAccounts.Count + 1; // Id tự sinh
                accounts.Acc = tbx_tk.Text;
                accounts.Pass = tbx_mk.Text;
                accounts.Sex = rbt_Nam.Checked ? 1 : 0;
                accounts.YearofBirth = Convert.ToInt16((combx_namsinh.SelectedItem));
                accounts.Status = cbx_hd.Checked; // ? false : true;
                if (MessageBox.Show("Bạn Có Muốn thêm ACC không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    if (MessageBox.Show("Bạn chăc chắn chứ ?", "Thông báo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        if (MessageBox.Show(" Mình nghĩ Bjan chưa chắc Đâu! \n Nhưng bạn có muốn tiếp tục lưu chứ?",
                                "Thông báo", MessageBoxButtons.YesNo) ==
                            DialogResult.Yes)
                        {
                            _servicesAccount.addAccount(accounts);
                            // sau Khi thêm xong thì tiến hành load data
                            LoadDaTa();
                            flash = 1;
                        }
                    }
                }

            }
        }


        //Sau khi gán thì dùng chứ năng thêm đối tượng


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
            if (MessageBox.Show("Bạn Có Muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                MessageBox.Show(_serviceFile.SaveFile(_fileNamePath, _lstAccounts), " thông báo");
            }
        }

        /*  

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
        private void gv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1. Lấy Index Rows Khi bấm vào Gird
            int rowIndex = e.RowIndex;
            if (rowIndex == _lstAccounts.Count) return;
            // 2. Lấy giá trị tại cột ID
            idAccWhenClick = Convert.ToInt16(gv_data.Rows[rowIndex].Cells[6].Value);
            // 3. có 2 cách để tìm được dối tượng
            // 3.1- Dùng Service dể tìm
            // 3.2 là sử dụng cách lấy giá trị tại cột
            tbx_tk.Text = gv_data.Rows[rowIndex].Cells[0].Value.ToString();
            tbx_mk.Text = gv_data.Rows[rowIndex].Cells[1].Value.ToString();
            rbt_Nam.Checked = gv_data.Rows[rowIndex].Cells[2].Value.ToString() == "Nam" ? true : false;
            rbt_Nu.Checked = gv_data.Rows[rowIndex].Cells[2].Value.ToString() == "Nữ" ? true : false;
            combx_namsinh.SelectedIndex = combx_namsinh.FindString(gv_data.Rows[rowIndex].Cells[3].Value.ToString());
            cbx_hd.Checked = gv_data.Rows[rowIndex].Cells[4].Value.ToString() == "Hoạt Động" ? true : false;
            cbx_khd.Checked = gv_data.Rows[rowIndex].Cells[4].Value.ToString() == "Không Hoạt Động" ? true : false;
        }

        void loadSan()
        {


            int rowIndex = 0;
            if (rowIndex == _lstAccounts.Count) return;
            // 2. Lấy giá trị tại cột ID
            var idAcc = gv_data.Rows[rowIndex].Cells[5].Value;
            // 3. có 2 cách để tìm được dối tượng
            // 3.1- Dùng Service dể tìm
            // 3.2 là sử dụng cách lấy giá trị tại cột
            tbx_tk.Text = gv_data.Rows[rowIndex].Cells[0].Value.ToString();
            tbx_mk.Text = gv_data.Rows[rowIndex].Cells[1].Value.ToString();
            rbt_Nam.Checked = gv_data.Rows[rowIndex].Cells[2].Value.ToString() == "Nam" ? true : false;
            rbt_Nu.Checked = gv_data.Rows[rowIndex].Cells[2].Value.ToString() == "Nữ" ? true : false;
            combx_namsinh.SelectedIndex = combx_namsinh.FindString(gv_data.Rows[rowIndex].Cells[3].Value.ToString());
            cbx_hd.Checked = gv_data.Rows[rowIndex].Cells[4].Value.ToString() == "Hoạt Động" ? true : false;
            cbx_khd.Checked = gv_data.Rows[rowIndex].Cells[4].Value.ToString() == "Không Hoạt Động" ? true : false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
            {
                MessageBox.Show(_servicesAccount.remove(_lstAccounts.Where(c => c.Acc == tbx_tk.Text).Select(c => c.Id).FirstOrDefault()), "thông báo");
                LoadDaTa();
                flash = 3;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {

                accounts = new Accounts();
                accounts.Id = idAccWhenClick;
                accounts.Acc = tbx_tk.Text;
                accounts.Pass = tbx_mk.Text;
                accounts.Sex = rbt_Nam.Checked ? 1 : 0;
                accounts.YearofBirth = Convert.ToInt16(combx_namsinh.SelectedItem);
                accounts.Status = cbx_hd.Checked;

                if (MessageBox.Show(" muốn Sửa chứ ?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    if (MessageBox.Show("Bạn chắc chắn đã điền thông tin rồi chứ!", "Thông báo",
                            MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        MessageBox.Show(_servicesAccount.edit(accounts), " thông báo");
                        LoadDaTa();
                        idAccWhenClick = -1;
                        flash = 2;
                    }
                }
            }
        }

        private void tbx_Search_KeyUp(object sender, KeyEventArgs e)
        {
            LoadDaTaBySearch(tbx_Search.Text);
        }
        void LoadDaTaBySearch(string acc)
        {
            _lstAccounts = new List<Accounts>();// khởi tạo lại
            _lstAccounts = _servicesAccount.getlstAcCountByAccounts(acc);// đổ dữ liệu vài lis Hiện tại
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
                    x.YearofBirth, x.Status == true ? "Hoạt Động" : "Không Hoạt Động", DateTime.Now.Year - x.YearofBirth, x.Id);
            }
        }


        private void btn_automk_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            tbx_mk.Text = Convert.ToString(a.Next(3,8));
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flash==1)
            {
                if (MessageBox.Show("Bạn vừa thêm ACC!\n Bạn Muốn lưu DS hiện tại không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_serviceFile.SaveFile(_fileNamePath, _lstAccounts), " thông báo");
                }
            }
            if (flash == 2)
            {
                if (MessageBox.Show("Bạn vừa sửa thông tin Acc !\n Bạn Muốn lưu DS hiện tại không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_serviceFile.SaveFile(_fileNamePath, _lstAccounts), " thông báo");
                }
            }
            if (flash == 3)
            {
                if (MessageBox.Show("Bạn vừa xóa ACC!\n Bạn Muốn lưu DS hiện tại không?", "Thông báo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    MessageBox.Show(_serviceFile.SaveFile(_fileNamePath, _lstAccounts), " thông báo");
                }
            }
        }
    }

}

