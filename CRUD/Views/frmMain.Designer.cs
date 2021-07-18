
namespace CRUD.Views
{
    partial class frmMain
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
            this.gr_hethong = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gv_data = new System.Windows.Forms.DataGridView();
            this.tbx_Search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.gr_chucnang = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.gr_Taotk = new System.Windows.Forms.GroupBox();
            this.btn_automk = new System.Windows.Forms.Button();
            this.cbx_khd = new System.Windows.Forms.CheckBox();
            this.cbx_hd = new System.Windows.Forms.CheckBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combx_namsinh = new System.Windows.Forms.ComboBox();
            this.rbt_Nu = new System.Windows.Forms.RadioButton();
            this.rbt_Nam = new System.Windows.Forms.RadioButton();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.tbx_mk = new System.Windows.Forms.TextBox();
            this.tbx_tk = new System.Windows.Forms.TextBox();
            this.lbl_mk = new System.Windows.Forms.Label();
            this.lbl_tk = new System.Windows.Forms.Label();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_luuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.đọcFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hackTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gr_hethong.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).BeginInit();
            this.gr_chucnang.SuspendLayout();
            this.gr_Taotk.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gr_hethong
            // 
            this.gr_hethong.AutoSize = true;
            this.gr_hethong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gr_hethong.Controls.Add(this.groupBox1);
            this.gr_hethong.Controls.Add(this.gr_chucnang);
            this.gr_hethong.Controls.Add(this.gr_Taotk);
            this.gr_hethong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gr_hethong.Location = new System.Drawing.Point(0, 31);
            this.gr_hethong.Name = "gr_hethong";
            this.gr_hethong.Size = new System.Drawing.Size(1018, 591);
            this.gr_hethong.TabIndex = 0;
            this.gr_hethong.TabStop = false;
            this.gr_hethong.Text = "Hệ Thống";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.gv_data);
            this.groupBox1.Controls.Add(this.tbx_Search);
            this.groupBox1.Controls.Add(this.lbl_search);
            this.groupBox1.Location = new System.Drawing.Point(0, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 333);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // gv_data
            // 
            this.gv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_data.Location = new System.Drawing.Point(4, 61);
            this.gv_data.MultiSelect = false;
            this.gv_data.Name = "gv_data";
            this.gv_data.RowHeadersWidth = 51;
            this.gv_data.RowTemplate.Height = 24;
            this.gv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_data.Size = new System.Drawing.Size(1002, 251);
            this.gv_data.TabIndex = 5;
            this.gv_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_data_CellClick);
            // 
            // tbx_Search
            // 
            this.tbx_Search.Location = new System.Drawing.Point(88, 21);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(152, 22);
            this.tbx_Search.TabIndex = 4;
            this.tbx_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbx_Search_KeyUp);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(9, 26);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(64, 17);
            this.lbl_search.TabIndex = 2;
            this.lbl_search.Text = "Tìm kiếm";
            // 
            // gr_chucnang
            // 
            this.gr_chucnang.AutoSize = true;
            this.gr_chucnang.Controls.Add(this.btn_sua);
            this.gr_chucnang.Controls.Add(this.btn_clear);
            this.gr_chucnang.Controls.Add(this.btn_xoa);
            this.gr_chucnang.Controls.Add(this.btn_them);
            this.gr_chucnang.Location = new System.Drawing.Point(431, 45);
            this.gr_chucnang.Name = "gr_chucnang";
            this.gr_chucnang.Size = new System.Drawing.Size(171, 186);
            this.gr_chucnang.TabIndex = 13;
            this.gr_chucnang.TabStop = false;
            this.gr_chucnang.Text = "Chức năng";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(6, 53);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(159, 23);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(6, 111);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(159, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(6, 82);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(159, 23);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(6, 21);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(159, 23);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // gr_Taotk
            // 
            this.gr_Taotk.AutoSize = true;
            this.gr_Taotk.Controls.Add(this.btn_automk);
            this.gr_Taotk.Controls.Add(this.cbx_khd);
            this.gr_Taotk.Controls.Add(this.cbx_hd);
            this.gr_Taotk.Controls.Add(this.lbl_status);
            this.gr_Taotk.Controls.Add(this.label1);
            this.gr_Taotk.Controls.Add(this.combx_namsinh);
            this.gr_Taotk.Controls.Add(this.rbt_Nu);
            this.gr_Taotk.Controls.Add(this.rbt_Nam);
            this.gr_Taotk.Controls.Add(this.lbl_sex);
            this.gr_Taotk.Controls.Add(this.tbx_mk);
            this.gr_Taotk.Controls.Add(this.tbx_tk);
            this.gr_Taotk.Controls.Add(this.lbl_mk);
            this.gr_Taotk.Controls.Add(this.lbl_tk);
            this.gr_Taotk.Location = new System.Drawing.Point(6, 36);
            this.gr_Taotk.Name = "gr_Taotk";
            this.gr_Taotk.Size = new System.Drawing.Size(419, 199);
            this.gr_Taotk.TabIndex = 0;
            this.gr_Taotk.TabStop = false;
            this.gr_Taotk.Text = "Tạo tài khoản";
            // 
            // btn_automk
            // 
            this.btn_automk.Location = new System.Drawing.Point(250, 55);
            this.btn_automk.Name = "btn_automk";
            this.btn_automk.Size = new System.Drawing.Size(163, 30);
            this.btn_automk.TabIndex = 12;
            this.btn_automk.Text = "Tự sinh mật khẩu";
            this.btn_automk.UseVisualStyleBackColor = true;
            this.btn_automk.Click += new System.EventHandler(this.btn_automk_Click);
            // 
            // cbx_khd
            // 
            this.cbx_khd.AutoSize = true;
            this.cbx_khd.Location = new System.Drawing.Point(184, 157);
            this.cbx_khd.Name = "cbx_khd";
            this.cbx_khd.Size = new System.Drawing.Size(139, 21);
            this.cbx_khd.TabIndex = 11;
            this.cbx_khd.Text = "Không họat động";
            this.cbx_khd.UseVisualStyleBackColor = true;
            this.cbx_khd.CheckedChanged += new System.EventHandler(this.cbx_khd_CheckedChanged);
            // 
            // cbx_hd
            // 
            this.cbx_hd.AutoSize = true;
            this.cbx_hd.Location = new System.Drawing.Point(82, 156);
            this.cbx_hd.Name = "cbx_hd";
            this.cbx_hd.Size = new System.Drawing.Size(96, 21);
            this.cbx_hd.TabIndex = 10;
            this.cbx_hd.Text = "Hoạt động";
            this.cbx_hd.UseVisualStyleBackColor = true;
            this.cbx_hd.CheckedChanged += new System.EventHandler(this.cbx_hd_CheckedChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(0, 157);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(73, 17);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Năm Sinh: ";
            // 
            // combx_namsinh
            // 
            this.combx_namsinh.FormattingEnabled = true;
            this.combx_namsinh.Location = new System.Drawing.Point(83, 115);
            this.combx_namsinh.Name = "combx_namsinh";
            this.combx_namsinh.Size = new System.Drawing.Size(151, 24);
            this.combx_namsinh.TabIndex = 7;
            // 
            // rbt_Nu
            // 
            this.rbt_Nu.AutoSize = true;
            this.rbt_Nu.Location = new System.Drawing.Point(157, 88);
            this.rbt_Nu.Name = "rbt_Nu";
            this.rbt_Nu.Size = new System.Drawing.Size(47, 21);
            this.rbt_Nu.TabIndex = 6;
            this.rbt_Nu.TabStop = true;
            this.rbt_Nu.Text = "Nữ";
            this.rbt_Nu.UseVisualStyleBackColor = true;
            // 
            // rbt_Nam
            // 
            this.rbt_Nam.AutoSize = true;
            this.rbt_Nam.Location = new System.Drawing.Point(83, 88);
            this.rbt_Nam.Name = "rbt_Nam";
            this.rbt_Nam.Size = new System.Drawing.Size(58, 21);
            this.rbt_Nam.TabIndex = 5;
            this.rbt_Nam.TabStop = true;
            this.rbt_Nam.Text = "Nam";
            this.rbt_Nam.UseVisualStyleBackColor = true;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(0, 88);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(69, 17);
            this.lbl_sex.TabIndex = 4;
            this.lbl_sex.Text = "Giới Tính:";
            // 
            // tbx_mk
            // 
            this.tbx_mk.Location = new System.Drawing.Point(82, 55);
            this.tbx_mk.Name = "tbx_mk";
            this.tbx_mk.PasswordChar = '*';
            this.tbx_mk.Size = new System.Drawing.Size(152, 22);
            this.tbx_mk.TabIndex = 3;
            // 
            // tbx_tk
            // 
            this.tbx_tk.Location = new System.Drawing.Point(82, 27);
            this.tbx_tk.Name = "tbx_tk";
            this.tbx_tk.Size = new System.Drawing.Size(152, 22);
            this.tbx_tk.TabIndex = 2;
            this.tbx_tk.TextChanged += new System.EventHandler(this.tbx_tk_TextChanged);
            // 
            // lbl_mk
            // 
            this.lbl_mk.AutoSize = true;
            this.lbl_mk.Location = new System.Drawing.Point(0, 54);
            this.lbl_mk.Name = "lbl_mk";
            this.lbl_mk.Size = new System.Drawing.Size(70, 17);
            this.lbl_mk.TabIndex = 1;
            this.lbl_mk.Text = "Mật khẩu:";
            // 
            // lbl_tk
            // 
            this.lbl_tk.AutoSize = true;
            this.lbl_tk.Location = new System.Drawing.Point(-3, 27);
            this.lbl_tk.Name = "lbl_tk";
            this.lbl_tk.Size = new System.Drawing.Size(79, 17);
            this.lbl_tk.TabIndex = 0;
            this.lbl_tk.Text = "Tài khoản: ";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_luuFile,
            this.đọcFileToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.hệThốngToolStripMenuItem.Text = "hệ thống";
            // 
            // mn_luuFile
            // 
            this.mn_luuFile.Name = "mn_luuFile";
            this.mn_luuFile.Size = new System.Drawing.Size(162, 26);
            this.mn_luuFile.Text = "Lưu File";
            this.mn_luuFile.Click += new System.EventHandler(this.mn_luuFile_Click);
            // 
            // đọcFileToolStripMenuItem
            // 
            this.đọcFileToolStripMenuItem.Name = "đọcFileToolStripMenuItem";
            this.đọcFileToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.đọcFileToolStripMenuItem.Text = "Đọc File";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // hackTàiKhoảnToolStripMenuItem
            // 
            this.hackTàiKhoảnToolStripMenuItem.Name = "hackTàiKhoảnToolStripMenuItem";
            this.hackTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.hackTàiKhoảnToolStripMenuItem.Text = "hack Tài khoản";
            // 
            // bayMàuToolStripMenuItem
            // 
            this.bayMàuToolStripMenuItem.Name = "bayMàuToolStripMenuItem";
            this.bayMàuToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.bayMàuToolStripMenuItem.Text = "bay màu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.hackTàiKhoảnToolStripMenuItem,
            this.bayMàuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1034, 635);
            this.Controls.Add(this.gr_hethong);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Màn hình chính";
            this.gr_hethong.ResumeLayout(false);
            this.gr_hethong.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).EndInit();
            this.gr_chucnang.ResumeLayout(false);
            this.gr_Taotk.ResumeLayout(false);
            this.gr_Taotk.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.GroupBox gr_hethong;
        private System.Windows.Forms.GroupBox gr_Taotk;
        private System.Windows.Forms.CheckBox cbx_khd;
        private System.Windows.Forms.CheckBox cbx_hd;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combx_namsinh;
        private System.Windows.Forms.RadioButton rbt_Nu;
        private System.Windows.Forms.RadioButton rbt_Nam;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.TextBox tbx_mk;
        private System.Windows.Forms.TextBox tbx_tk;
        private System.Windows.Forms.Label lbl_mk;
        private System.Windows.Forms.Label lbl_tk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gv_data;
        private System.Windows.Forms.TextBox tbx_Search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.GroupBox gr_chucnang;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_automk;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_luuFile;
        private System.Windows.Forms.ToolStripMenuItem đọcFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hackTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bayMàuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
