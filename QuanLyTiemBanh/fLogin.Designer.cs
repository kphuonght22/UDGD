namespace QuanLyTiemBanh
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxAdmin = new System.Windows.Forms.CheckBox();
            this.cbxStaff = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPassWord = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxAdmin);
            this.panel1.Controls.Add(this.cbxStaff);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.tbxPassWord);
            this.panel1.Controls.Add(this.tbxUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lable2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 255);
            this.panel1.TabIndex = 0;
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.Location = new System.Drawing.Point(303, 63);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(92, 24);
            this.cbxAdmin.TabIndex = 2;
            this.cbxAdmin.Text = "Admin";
            this.cbxAdmin.UseVisualStyleBackColor = true;
            this.cbxAdmin.CheckedChanged += new System.EventHandler(this.cbxAdmin_CheckedChanged);
            // 
            // cbxStaff
            // 
            this.cbxStaff.Location = new System.Drawing.Point(173, 63);
            this.cbxStaff.Name = "cbxStaff";
            this.cbxStaff.Size = new System.Drawing.Size(104, 24);
            this.cbxStaff.TabIndex = 1;
            this.cbxStaff.Text = "Nhân Viên";
            this.cbxStaff.UseVisualStyleBackColor = true;
            this.cbxStaff.CheckedChanged += new System.EventHandler(this.cbxStaff_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(10, 201);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPassWord
            // 
            this.tbxPassWord.Location = new System.Drawing.Point(173, 145);
            this.tbxPassWord.Name = "tbxPassWord";
            this.tbxPassWord.PasswordChar = '*';
            this.tbxPassWord.Size = new System.Drawing.Size(222, 22);
            this.tbxPassWord.TabIndex = 4;
            this.tbxPassWord.UseSystemPasswordChar = true;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(173, 105);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(222, 22);
            this.tbxUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lable2
            // 
            this.lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(10, 105);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(157, 22);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "Tên đăng nhập:";
            this.lable2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPassWord;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.CheckBox cbxAdmin;
        private System.Windows.Forms.CheckBox cbxStaff;
    }
}

