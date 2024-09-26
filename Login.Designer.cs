namespace QLY_DIEM
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLogin = new Panel();
            lblName = new Label();
            pnlControlLogin = new Panel();
            cbxPhanquyen = new CheckBox();
            btnOut = new Button();
            btnLogin = new Button();
            pnlPassword = new Panel();
            lbShow = new Label();
            lblPassword = new Label();
            tbxPassword = new TextBox();
            pnlUser = new Panel();
            lblUser = new Label();
            tbxUser = new TextBox();
            pnlLogin.SuspendLayout();
            pnlControlLogin.SuspendLayout();
            pnlPassword.SuspendLayout();
            pnlUser.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.SkyBlue;
            pnlLogin.Controls.Add(lblName);
            pnlLogin.Controls.Add(pnlControlLogin);
            pnlLogin.Controls.Add(pnlPassword);
            pnlLogin.Controls.Add(pnlUser);
            pnlLogin.Location = new Point(-1, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(514, 234);
            pnlLogin.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(112, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(289, 37);
            lblName.TabIndex = 5;
            lblName.Text = "HỆ THỐNG ĐIỂM THPT";
            // 
            // pnlControlLogin
            // 
            pnlControlLogin.Controls.Add(cbxPhanquyen);
            pnlControlLogin.Controls.Add(btnOut);
            pnlControlLogin.Controls.Add(btnLogin);
            pnlControlLogin.Location = new Point(13, 163);
            pnlControlLogin.Name = "pnlControlLogin";
            pnlControlLogin.Size = new Size(490, 64);
            pnlControlLogin.TabIndex = 4;
            // 
            // cbxPhanquyen
            // 
            cbxPhanquyen.AutoSize = true;
            cbxPhanquyen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxPhanquyen.Location = new Point(5, 3);
            cbxPhanquyen.Name = "cbxPhanquyen";
            cbxPhanquyen.Size = new Size(146, 23);
            cbxPhanquyen.TabIndex = 3;
            cbxPhanquyen.Text = "Dành cho giáo viên";
            cbxPhanquyen.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            btnOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOut.Location = new Point(391, 14);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(96, 39);
            btnOut.TabIndex = 2;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(264, 14);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 39);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlPassword
            // 
            pnlPassword.Controls.Add(lbShow);
            pnlPassword.Controls.Add(lblPassword);
            pnlPassword.Controls.Add(tbxPassword);
            pnlPassword.Location = new Point(13, 106);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(490, 51);
            pnlPassword.TabIndex = 3;
            // 
            // lbShow
            // 
            lbShow.AutoSize = true;
            lbShow.BackColor = Color.White;
            lbShow.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbShow.Location = new Point(453, 15);
            lbShow.Name = "lbShow";
            lbShow.Size = new Size(28, 19);
            lbShow.TabIndex = 3;
            lbShow.Text = "👁️";
            lbShow.MouseLeave += lbShow_MouseLeave;
            lbShow.MouseHover += lbShow_MouseHover;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(5, 9);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 30);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbxPassword.Location = new Point(172, 6);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(315, 36);
            tbxPassword.TabIndex = 1;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // pnlUser
            // 
            pnlUser.AutoSize = true;
            pnlUser.Controls.Add(lblUser);
            pnlUser.Controls.Add(tbxUser);
            pnlUser.Location = new Point(13, 49);
            pnlUser.Name = "pnlUser";
            pnlUser.Size = new Size(490, 53);
            pnlUser.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(5, 10);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(161, 30);
            lblUser.TabIndex = 2;
            lblUser.Text = "Tên đăng nhập:";
            // 
            // tbxUser
            // 
            tbxUser.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbxUser.Location = new Point(172, 7);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(315, 36);
            tbxUser.TabIndex = 1;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 234);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlControlLogin.ResumeLayout(false);
            pnlControlLogin.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            pnlUser.ResumeLayout(false);
            pnlUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Panel pnlUser;
        private TextBox tbxUser;
        private Label lblUser;
        private Panel pnlPassword;
        private Label lblPassword;
        private TextBox tbxPassword;
        private Panel pnlControlLogin;
        private Button btnOut;
        private Button btnLogin;
        private Label lblName;
        private Label lbShow;
        private CheckBox cbxPhanquyen;
    }
}