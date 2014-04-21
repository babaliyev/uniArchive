using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace UniArchive.copy
{
    public partial class CopyManager : DevExpress.XtraEditors.XtraUserControl
    {
        protected decimal id;
        protected decimal documentId;

        public CopyManager()
        {
            InitializeComponent();  
        }
        
        public void setData(FullDataSet fds, decimal documentId)
        {
            this.documentId = documentId; 
            fullDataSet = fds;

            documentsBindingSource.DataSource = fullDataSet;
            copyTypesBindingSource.DataSource = fullDataSet;
            copiesBindingSource.DataSource = fullDataSet;

            documentsBindingSource.ResetBindings(true);
            copyTypesBindingSource.ResetBindings(true);
            copiesBindingSource.ResetBindings(true);            
        }

        public void edit(decimal id)
        {
            this.id = id;
            copiesBindingSource.Position = copiesBindingSource.Find("ID", id);
            filesManager1.setCopyId(fullDataSet, id);
        }

        public void addNew()
        {
            DataRow newRow = ((DataRowView)copiesBindingSource.AddNew()).Row;
            id = DataHelper.GET_COPIES_ID();
            newRow["ID"] = id;
            newRow["FULL_ACCESS"] = 1;
            newRow["DOCUMENT_ID"] = this.documentId;

            filesManager1.setCopyId(fullDataSet, id);
        }
              
        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    DataRow newRow = ((DataRowView)copiesBindingSource.Current).Row;
                    newRow["PAGES_COUNT"] = filesManager1.filesCount;
                    this.copiesBindingSource.EndEdit();

                    if(OnSave!=null)
                        OnSave(this, EventArgs.Empty);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        public event EventHandler OnSave;
        public event EventHandler OnDocumentClick;

        private void documentLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OnDocumentClick != null)
                OnDocumentClick(documentLinkLabel.Tag, EventArgs.Empty);
        }
    }
}
