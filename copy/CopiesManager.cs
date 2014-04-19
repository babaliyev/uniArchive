using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.copy
{
    public partial class CopiesManager : DevExpress.XtraEditors.XtraUserControl
    {
        private decimal documentId;

        public CopiesManager()
        {
            InitializeComponent();
            this.copyTypesTableAdapter.Fill(this.fullDataSet.COPY_TYPES);
        }

        public void save()
        {
            if (this.Validate())
            {
                try
                {
                    this.copiesBindingSource.EndEdit();
                    this.copiesTableAdapter.Update(this.fullDataSet.COPIES);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void setDocumentId(decimal id)
        {
            this.documentId = id;
            this.documentsTableAdapter.FillByID(this.fullDataSet.DOCUMENTS, this.documentId);
            this.copiesTableAdapter.FillByDocumentID(this.fullDataSet.COPIES, this.documentId);
        }

        private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CopyForm copyForm = new CopyForm(fullDataSet, documentId);
            if (copyForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (copiesBindingSource.Count > 0)
            {
                if (copiesBindingSource.Current != null)
                {
                    int pos = copiesBindingSource.Position;
                    DataRow row = (DataRow)((DataRowView)copiesBindingSource.Current).Row;
                    decimal id = Convert.ToDecimal(row["ID"]);
                    CopyForm copyForm = new CopyForm(fullDataSet,documentId,id);
                    if (copyForm.ShowDialog() == DialogResult.OK)
                    {
                        copiesBindingSource.Position = pos;
                    }
                }
            }
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult res = MessageBox.Show("Seçdiyiniz qoşma silinsin ? ", "Əminsiniz?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                this.copiesBindingSource.RemoveCurrent();
                this.copiesBindingSource.EndEdit();
            }
        }
    }
}
