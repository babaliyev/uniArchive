namespace UniArchive
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_Login = new DevExpress.XtraEditors.SimpleButton();
            this.b_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.l_Password = new System.Windows.Forms.Label();
            this.l_UserNmae = new System.Windows.Forms.Label();
            this.t_UserPassword = new DevExpress.XtraEditors.TextEdit();
            this.t_UserName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_UserPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_UserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.pictureBox1);
            this.groupControl.Controls.Add(this.b_Login);
            this.groupControl.Controls.Add(this.b_Cancel);
            this.groupControl.Controls.Add(this.l_Password);
            this.groupControl.Controls.Add(this.l_UserNmae);
            this.groupControl.Controls.Add(this.t_UserPassword);
            this.groupControl.Controls.Add(this.t_UserName);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(267, 128);
            this.groupControl.TabIndex = 17;
            this.groupControl.Text = "       Sistemə giriş";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // b_Login
            // 
            this.b_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Login.Location = new System.Drawing.Point(99, 95);
            this.b_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_Login.Name = "b_Login";
            this.b_Login.Size = new System.Drawing.Size(75, 23);
            this.b_Login.TabIndex = 5;
            this.b_Login.Text = "Giriş";
            this.b_Login.Click += new System.EventHandler(this.b_Login_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_Cancel.Location = new System.Drawing.Point(180, 95);
            this.b_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 6;
            this.b_Cancel.Text = "İmtina";
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.l_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_Password.Location = new System.Drawing.Point(14, 62);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(41, 13);
            this.l_Password.TabIndex = 21;
            this.l_Password.Text = "Parolu:";
            // 
            // l_UserNmae
            // 
            this.l_UserNmae.AutoSize = true;
            this.l_UserNmae.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l_UserNmae.Location = new System.Drawing.Point(14, 37);
            this.l_UserNmae.Name = "l_UserNmae";
            this.l_UserNmae.Size = new System.Drawing.Size(72, 13);
            this.l_UserNmae.TabIndex = 20;
            this.l_UserNmae.Text = "İstifadəçi adı:";
            // 
            // t_UserPassword
            // 
            this.t_UserPassword.Location = new System.Drawing.Point(116, 59);
            this.t_UserPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_UserPassword.Name = "t_UserPassword";
            this.t_UserPassword.Properties.PasswordChar = '*';
            this.t_UserPassword.Size = new System.Drawing.Size(139, 20);
            this.t_UserPassword.TabIndex = 2;
            // 
            // t_UserName
            // 
            this.t_UserName.Location = new System.Drawing.Point(116, 35);
            this.t_UserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.t_UserName.Name = "t_UserName";
            this.t_UserName.Size = new System.Drawing.Size(139, 20);
            this.t_UserName.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 128);
            this.Controls.Add(this.groupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_UserPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_UserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton b_Login;
        private DevExpress.XtraEditors.SimpleButton b_Cancel;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.Label l_UserNmae;
        private DevExpress.XtraEditors.TextEdit t_UserPassword;
        private DevExpress.XtraEditors.TextEdit t_UserName;
    }
}