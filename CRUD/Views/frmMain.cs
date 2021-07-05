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
    public partial class frmMain : Form
    {

        //private IServiceAccount pt = new ServiceAccount();
        private int gioitinh;
        private bool Stt;

        public frmMain()
        {
            InitializeComponent();
            loadNawmSinh();
        }

        void loadNawmSinh()
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
            //foreach (var x in pt.aa())
            //{
            //    gv_data.Rows.Add(x.Acc, x.Pass, x.Sex == 1 ? "Nam" : x.Sex == 0 ? "Nữ" : "", x.YearofBirth, x.Status == true ? "Hoạt Động" : "Không Hoạt Động");
            //}


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
            Stt = true;
        }

        private void cbx_khd_CheckedChanged(object sender, EventArgs e)
        {
            Stt = false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {

            string ten = tbx_tk.Text;
            string mk = tbx_mk.Text;
            int sex = gioitinh;
            int namSinh = Convert.ToInt16(combx_namsinh.Text);
            bool STT = Stt;

           // pt.Add(ten, mk, sex, namSinh, STT);
            MessageBox.Show("thêm thành Công", " thông báo");
            gridview();
        }

     
    }
}

