
namespace CRUD.Views
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region MyRegion

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_TaoTK = new System.Windows.Forms.GroupBox();
            this.btn_ShowPass = new System.Windows.Forms.Button();
            this.cbx_Namsinh = new System.Windows.Forms.ComboBox();
            this.tbx_mk = new System.Windows.Forms.TextBox();
            this.tbx_tk = new System.Windows.Forms.TextBox();
            this.rbtn_nu = new System.Windows.Forms.RadioButton();
            this.rbtn_nam = new System.Windows.Forms.RadioButton();
            this.btn_tusinhmk = new System.Windows.Forms.Button();
            this.btn_Taotk = new System.Windows.Forms.Button();
            this.lbl_Namsinh = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_MK = new System.Windows.Forms.Label();
            this.lbl_tk = new System.Windows.Forms.Label();
            this.gb_TaoTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TaoTK
            // 
            this.gb_TaoTK.Controls.Add(this.btn_ShowPass);
            this.gb_TaoTK.Controls.Add(this.cbx_Namsinh);
            this.gb_TaoTK.Controls.Add(this.tbx_mk);
            this.gb_TaoTK.Controls.Add(this.tbx_tk);
            this.gb_TaoTK.Controls.Add(this.rbtn_nu);
            this.gb_TaoTK.Controls.Add(this.rbtn_nam);
            this.gb_TaoTK.Controls.Add(this.btn_tusinhmk);
            this.gb_TaoTK.Controls.Add(this.btn_Taotk);
            this.gb_TaoTK.Controls.Add(this.lbl_Namsinh);
            this.gb_TaoTK.Controls.Add(this.lbl_sex);
            this.gb_TaoTK.Controls.Add(this.lbl_MK);
            this.gb_TaoTK.Controls.Add(this.lbl_tk);
            this.gb_TaoTK.Location = new System.Drawing.Point(12, 12);
            this.gb_TaoTK.Name = "gb_TaoTK";
            this.gb_TaoTK.Size = new System.Drawing.Size(440, 245);
            this.gb_TaoTK.TabIndex = 0;
            this.gb_TaoTK.TabStop = false;
            this.gb_TaoTK.Text = "Tạo tài khoản";
            // 
            // btn_ShowPass
            // 
            this.btn_ShowPass.Location = new System.Drawing.Point(289, 101);
            this.btn_ShowPass.Name = "btn_ShowPass";
            this.btn_ShowPass.Size = new System.Drawing.Size(142, 23);
            this.btn_ShowPass.TabIndex = 23;
            this.btn_ShowPass.Text = "Show Pass";
            this.btn_ShowPass.UseVisualStyleBackColor = true;
            this.btn_ShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ShowPass_MouseDown);
            this.btn_ShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ShowPass_MouseUp);
            // 
            // cbx_Namsinh
            // 
            this.cbx_Namsinh.FormattingEnabled = true;
            this.cbx_Namsinh.Location = new System.Drawing.Point(102, 144);
            this.cbx_Namsinh.Name = "cbx_Namsinh";
            this.cbx_Namsinh.Size = new System.Drawing.Size(168, 24);
            this.cbx_Namsinh.TabIndex = 22;
            this.cbx_Namsinh.Text = "1998";
            // 
            // tbx_mk
            // 
            this.tbx_mk.Location = new System.Drawing.Point(102, 59);
            this.tbx_mk.Name = "tbx_mk";
            this.tbx_mk.PasswordChar = '*';
            this.tbx_mk.Size = new System.Drawing.Size(168, 22);
            this.tbx_mk.TabIndex = 21;
            this.tbx_mk.Text = "1";
            // 
            // tbx_tk
            // 
            this.tbx_tk.Location = new System.Drawing.Point(102, 15);
            this.tbx_tk.Name = "tbx_tk";
            this.tbx_tk.Size = new System.Drawing.Size(168, 22);
            this.tbx_tk.TabIndex = 20;
            this.tbx_tk.Text = "beubau_csnv@gmail.com";
            // 
            // rbtn_nu
            // 
            this.rbtn_nu.AutoSize = true;
            this.rbtn_nu.Location = new System.Drawing.Point(184, 103);
            this.rbtn_nu.Name = "rbtn_nu";
            this.rbtn_nu.Size = new System.Drawing.Size(47, 21);
            this.rbtn_nu.TabIndex = 19;
            this.rbtn_nu.Text = "Nữ";
            this.rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_nam
            // 
            this.rbtn_nam.AutoSize = true;
            this.rbtn_nam.Location = new System.Drawing.Point(102, 103);
            this.rbtn_nam.Name = "rbtn_nam";
            this.rbtn_nam.Size = new System.Drawing.Size(58, 21);
            this.rbtn_nam.TabIndex = 18;
            this.rbtn_nam.Text = "Nam";
            this.rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // btn_tusinhmk
            // 
            this.btn_tusinhmk.Location = new System.Drawing.Point(289, 58);
            this.btn_tusinhmk.Name = "btn_tusinhmk";
            this.btn_tusinhmk.Size = new System.Drawing.Size(142, 23);
            this.btn_tusinhmk.TabIndex = 17;
            this.btn_tusinhmk.Text = "Tự sinh mật khẩu";
            this.btn_tusinhmk.UseVisualStyleBackColor = true;
            this.btn_tusinhmk.Click += new System.EventHandler(this.btn_tusinhmk_Click);
            // 
            // btn_Taotk
            // 
            this.btn_Taotk.Location = new System.Drawing.Point(160, 187);
            this.btn_Taotk.Name = "btn_Taotk";
            this.btn_Taotk.Size = new System.Drawing.Size(156, 43);
            this.btn_Taotk.TabIndex = 16;
            this.btn_Taotk.Text = "Tạo Tài Khoản";
            this.btn_Taotk.UseVisualStyleBackColor = true;
            this.btn_Taotk.Click += new System.EventHandler(this.btn_Taotk_Click);
            // 
            // lbl_Namsinh
            // 
            this.lbl_Namsinh.AutoSize = true;
            this.lbl_Namsinh.Location = new System.Drawing.Point(16, 151);
            this.lbl_Namsinh.Name = "lbl_Namsinh";
            this.lbl_Namsinh.Size = new System.Drawing.Size(69, 17);
            this.lbl_Namsinh.TabIndex = 15;
            this.lbl_Namsinh.Text = "Năm Sinh";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(23, 103);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(62, 18);
            this.lbl_sex.TabIndex = 14;
            this.lbl_sex.Text = "Giới tính";
            // 
            // lbl_MK
            // 
            this.lbl_MK.AutoSize = true;
            this.lbl_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MK.Location = new System.Drawing.Point(14, 63);
            this.lbl_MK.Name = "lbl_MK";
            this.lbl_MK.Size = new System.Drawing.Size(71, 18);
            this.lbl_MK.TabIndex = 13;
            this.lbl_MK.Text = "Mật Khẩu";
            // 
            // lbl_tk
            // 
            this.lbl_tk.AutoSize = true;
            this.lbl_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tk.Location = new System.Drawing.Point(10, 19);
            this.lbl_tk.Name = "lbl_tk";
            this.lbl_tk.Size = new System.Drawing.Size(75, 18);
            this.lbl_tk.TabIndex = 12;
            this.lbl_tk.Text = "Tài Khoản";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 302);
            this.Controls.Add(this.gb_TaoTK);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.gb_TaoTK.ResumeLayout(false);
            this.gb_TaoTK.PerformLayout();
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.GroupBox gb_TaoTK;
        private System.Windows.Forms.Button btn_ShowPass;
        private System.Windows.Forms.ComboBox cbx_Namsinh;
        private System.Windows.Forms.TextBox tbx_mk;
        private System.Windows.Forms.TextBox tbx_tk;
        private System.Windows.Forms.RadioButton rbtn_nu;
        private System.Windows.Forms.RadioButton rbtn_nam;
        private System.Windows.Forms.Button btn_tusinhmk;
        private System.Windows.Forms.Button btn_Taotk;
        private System.Windows.Forms.Label lbl_Namsinh;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_MK;
        private System.Windows.Forms.Label lbl_tk;
    }
}