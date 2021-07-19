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
    public partial class frmFogotPassWord : Form
    {
        private ICheck checkEveryThings;
        private IServicesAccount SvAcc;
        private IServiceFile svFile;
        private Accounts accounts;
        private List<Accounts> lstAcc;
        private string path = @"E:\C# (Sharp)\C#3\CRUD\buồn.txt";

        public frmFogotPassWord()
        {
            checkEveryThings = new CheckEveryThing();
            svFile = new SerViceFiles();
            SvAcc = new ServicesAcounts();
            lstAcc = new List<Accounts>();
            InitializeComponent();
            loadNamSinh();
            mkmoi.Hide();
        }

        void loadNamSinh()
        {
            foreach (var a in SvAcc.getYearofBirth())
            {
                combx_namsinh.Items.Add(a);
            }
        }

        private void btn_Tieptheo_Click(object sender, EventArgs e)
        {
            

            if (checkEveryThings.checkNull(tbx_tk.Text))
            {
                MessageBox.Show(" Không đƯợc để trống Tài Khoản Và Mật Khẩu", " Erorr 400");
                return;
            }

            if (checkEveryThings.CheckAcc(tbx_tk.Text) == false)
            {
                MessageBox.Show("Tên Tài Khoản Phải có chữ số", " Erorr 400");
                return;
            }
            if (checkEveryThings.CheckYearofBirth(combx_namsinh.Text) == false)
            {
                MessageBox.Show("Năm Sinh không đượcc nhập chữ", " Erorr 400");
                return;
            }
            lstAcc = svFile.OpenFile<Accounts>(path);
            var b = lstAcc.FirstOrDefault(a =>
                a.Acc == tbx_tk.Text && a.Sex == (rbt_Nam.Checked ? 1 : 0) &&
                a.YearofBirth == Convert.ToInt16(combx_namsinh.Text));
            if (b!= null)
            {
                MessageBox.Show(" Đã tìm thấy tài khoản", " Thông báo");
                mkmoi.Show();
            }
            else
            {
                MessageBox.Show(" tài khoản bạn tìm không có!", " thông báo");
            }
        }


        private void btn_mk_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();

            if (checkEveryThings.checkNull(mkNew.Text) || checkEveryThings.checkNull(xn_mkNew.Text))
            {
                MessageBox.Show(" Không đƯợc để trống Mật khẩu mới và Xác nhận mật khẩu", " Erorr 400");
                return;
            }

            if (checkEveryThings.checkMK(mkNew.Text) || checkEveryThings.checkMK(xn_mkNew.Text))
            {
                MessageBox.Show(" Mật khẩu mới có nhiều hơn 3 ký tự", " Erorr 400");
                return;
            }
            if (mkNew.Text != xn_mkNew.Text)
            {
                MessageBox.Show(" Xác Nhận mật khẩu chưa trùng", "thông báo");
                return;
            }
            else
            {
                int index = lstAcc.FindIndex(c => c.Acc == tbx_tk.Text);
                lstAcc[index].Pass = xn_mkNew.Text;
                svFile.SaveFile(path, lstAcc);
                MessageBox.Show("Đổi Mật Khẩu thanh công!", " thông báo");
                frm.Show();
                this.Close();
            }
        }
    }
}
