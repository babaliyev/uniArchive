using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.directoryTree
{
    public partial class DirectoryForm : DevExpress.XtraEditors.XtraForm
    {
        private decimal? parentId;

        public DirectoryForm(decimal? parentId)
        {
            InitializeComponent();
            this.parentId = parentId;

            DataRow newRow = ((DataRowView)directoriesBindingSource.AddNew()).Row;
            newRow["ID"] = DataHelper.GET_DOCUMENTS_ID();
            newRow["FULL_ACCESS"] = 1;
            newRow["PARENT_ID"] = parentId == null ? (object)DBNull.Value : (object)parentId;
        }

        public DirectoryForm(decimal id)
        {
            InitializeComponent();
            this.directoriesTableAdapter.FillByID(this.fullDataSet.DIRECTORIES,id);
        }

        private void okSimpleButton_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    this.directoriesBindingSource.EndEdit();
                    this.directoriesTableAdapter.Update(fullDataSet.DIRECTORIES);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}