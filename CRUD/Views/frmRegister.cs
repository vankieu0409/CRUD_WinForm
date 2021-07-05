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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
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
    }
}
