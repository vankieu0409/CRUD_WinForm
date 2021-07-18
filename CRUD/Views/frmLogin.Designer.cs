
namespace CRUD.Views
{
    partial class frmLogin
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
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tk = new System.Windows.Forms.Label();
            this.lbl_Quenmk = new System.Windows.Forms.LinkLabel();
            this.tbx_tk = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.mk = new System.Windows.Forms.Label();
            this.tbx_mk = new System.Windows.Forms.TextBox();
            this.lbl_dk = new System.Windows.Forms.LinkLabel();
            this.btn_Data = new System.Windows.Forms.Button();
            this.lbl_fileNamePath = new System.Windows.Forms.Label();
            this.lbl_checkdata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tk
            // 
            this.tk.AutoSize = true;
            this.tk.Location = new System.Drawing.Point(28, 23);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(75, 17);
            this.tk.TabIndex = 0;
            this.tk.Text = "Tài khoản:";
            // 
            // lbl_Quenmk
            // 
            this.lbl_Quenmk.AutoSize = true;
            this.lbl_Quenmk.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbl_Quenmk.Location = new System.Drawing.Point(166, 100);
            this.lbl_Quenmk.Name = "lbl_Quenmk";
            this.lbl_Quenmk.Size = new System.Drawing.Size(113, 17);
            this.lbl_Quenmk.TabIndex = 3;
            this.lbl_Quenmk.TabStop = true;
            this.lbl_Quenmk.Text = "Quên mật khẩu?";
            this.lbl_Quenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Quenmk_LinkClicked);
            // 
            // tbx_tk
            // 
            this.tbx_tk.Location = new System.Drawing.Point(119, 23);
            this.tbx_tk.Name = "tbx_tk";
            this.tbx_tk.Size = new System.Drawing.Size(160, 22);
            this.tbx_tk.TabIndex = 1;
            this.tbx_tk.Text = "kieu";

            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(116, 160);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(93, 32);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.Enter += new System.EventHandler(this.btn_login_Click);
            // 
            // mk
            // 
            this.mk.AutoSize = true;
            this.mk.Location = new System.Drawing.Point(33, 65);
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(70, 17);
            this.mk.TabIndex = 4;
            this.mk.Text = "Mật khẩu:";
            // 
            // tbx_mk
            // 
            this.tbx_mk.Location = new System.Drawing.Point(119, 65);
            this.tbx_mk.Name = "tbx_mk";
            this.tbx_mk.PasswordChar = '*';
            this.tbx_mk.Size = new System.Drawing.Size(160, 22);
            this.tbx_mk.TabIndex = 2;
            this.tbx_mk.Text = "1";
            // 
            // lbl_dk
            // 
            this.lbl_dk.AutoSize = true;
            this.lbl_dk.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbl_dk.Location = new System.Drawing.Point(166, 128);
            this.lbl_dk.Name = "lbl_dk";
            this.lbl_dk.Size = new System.Drawing.Size(68, 17);
            this.lbl_dk.TabIndex = 4;
            this.lbl_dk.TabStop = true;
            this.lbl_dk.Text = "Đăng ký?";
            this.lbl_dk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_dk_LinkClicked);
            // 
            // btn_Data
            // 
            this.btn_Data.Location = new System.Drawing.Point(28, 120);
            this.btn_Data.Name = "btn_Data";
            this.btn_Data.Size = new System.Drawing.Size(93, 32);
            this.btn_Data.TabIndex = 6;
            this.btn_Data.Text = "Mở data";
            this.btn_Data.UseVisualStyleBackColor = true;
            this.btn_Data.Click += new System.EventHandler(this.btn_Data_Click);
            // 
            // lbl_fileNamePath
            // 
            this.lbl_fileNamePath.AutoSize = true;
            this.lbl_fileNamePath.Location = new System.Drawing.Point(33, 193);
            this.lbl_fileNamePath.Name = "lbl_fileNamePath";
            this.lbl_fileNamePath.Size = new System.Drawing.Size(39, 17);
            this.lbl_fileNamePath.TabIndex = 7;
            this.lbl_fileNamePath.Text = "chán\r\n";
            // 
            // lbl_checkdata
            // 
            this.lbl_checkdata.AutoSize = true;
            this.lbl_checkdata.Location = new System.Drawing.Point(33, 168);
            this.lbl_checkdata.Name = "lbl_checkdata";
            this.lbl_checkdata.Size = new System.Drawing.Size(39, 17);
            this.lbl_checkdata.TabIndex = 8;
            this.lbl_checkdata.Text = "chán\r\n";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 219);
            this.Controls.Add(this.lbl_checkdata);
            this.Controls.Add(this.lbl_fileNamePath);
            this.Controls.Add(this.btn_Data);
            this.Controls.Add(this.lbl_dk);
            this.Controls.Add(this.tbx_mk);
            this.Controls.Add(this.mk);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_tk);
            this.Controls.Add(this.lbl_Quenmk);
            this.Controls.Add(this.tk);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_Data;

        private System.Windows.Forms.Label lbl_fileNamePath;

        #endregion

        private System.Windows.Forms.Label tk;
        private System.Windows.Forms.LinkLabel lbl_Quenmk;
        private System.Windows.Forms.TextBox tbx_tk;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label mk;
        private System.Windows.Forms.TextBox tbx_mk;
        private System.Windows.Forms.LinkLabel lbl_dk;
        private System.Windows.Forms.Label lbl_checkdata;
    }
}