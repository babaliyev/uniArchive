using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.document
{
    public partial class DocumentManager : DevExpress.XtraEditors.XtraUserControl
    {
        private decimal id;

        public DocumentManager(decimal id)
        {
            InitializeComponent();
            loadReferences();
            this.documentsTableAdapter.FillByID(this.fullDataSet.DOCUMENTS, id);
            this.id = id;
            this.copiesManager1.setDocumentId(id);
        }

        public DocumentManager()
        {
            InitializeComponent();
            loadReferences();

            DataRow newRow = ((DataRowView)documentsBindingSource.AddNew()).Row;
            id = DataHelper.GET_DOCUMENTS_ID();
            newRow["ID"] = id;
            newRow["FULL_ACCESS"] = 1;
            this.copiesManager1.setDocumentId(id);
        }

        public void loadReferences()
        {
            this.addressDictionaryTableAdapter.Fill(this.fullDataSet.ADDRESS_DICTIONARY);
            this.documentTypesTableAdapter.Fill(this.fullDataSet.DOCUMENT_TYPES);
            this.directoriesTableAdapter.Fill(fullDataSet.DIRECTORIES);
            this.clientsTableAdapter.Fill(fullDataSet.CLIENTS);
        }

        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    this.documentsBindingSource.EndEdit();
                    this.documentsTableAdapter.Update(this.fullDataSet.DOCUMENTS);
                    this.copiesManager1.save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }
    }
}
