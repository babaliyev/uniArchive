using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.clients
{
    public partial class ClientForm : DevExpress.XtraEditors.XtraForm
    {
        public ClientForm()
        {
            InitializeComponent();
            DataRow newRow = ((DataRowView)clientsBindingSource.AddNew()).Row;
            newRow["ID"] = DataHelper.GET_CLIENTS_ID();
            newRow["FULL_ACCESS"] = 1;
        }

        public ClientForm(decimal id)
        {
            InitializeComponent();
            this.clientsTableAdapter.FillByID(fullDataSet.CLIENTS, id);
        }

        private void okSimpleButton_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    this.clientsBindingSource.EndEdit();
                    this.clientsTableAdapter.Update(fullDataSet.CLIENTS);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool Validate()
        {
            bool validateResult = true;
            validateResult = validateResult && UIHelper.requiredField_Validating(clientTypeRadioGroup);
            validateResult = validateResult && UIHelper.requiredField_Validating(nameTextEdit);
            validateResult = validateResult && UIHelper.requiredField_Validating(fullAccessCheckEdit);
            return validateResult;
        }
    }
}