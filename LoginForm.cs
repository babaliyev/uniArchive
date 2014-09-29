using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Oracle.DataAccess.Client;

namespace UniArchive
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void b_Login_Click(object sender, EventArgs e)
        {
            string connectionString = "DATA SOURCE=arch;PASSWORD="+t_UserPassword.Text+";USER ID="+t_UserName.Text+"";

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Properties.Settings.Default["archConnectionString"] = connectionString;
                    conn.Close();
                     DialogResult = DialogResult.Yes;
                     Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Giriş səhvi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}